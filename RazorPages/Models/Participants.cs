using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace RazorPages.Models
{
    public class Participants
    {
        //public const string participantsFile = "Participants.json";
        public const string participantsFile = "c:\\Users\\p.titov\\source\\repos\\L2-P3-10. HttpWebServer\\L2-P3-10. HttpWebServer\\wwwroot\\Participants.json";
         public static ParticipantsView Read(string path)
        {
            if (!File.Exists(path))
                return null;

            object p;

            using (StreamReader file = new StreamReader(path))
            {
                String participantsString = file.ReadToEnd();
                p = JsonConvert.DeserializeObject(participantsString, typeof(ParticipantsView));
            }
            return p as ParticipantsView;
        }

        public static void Write(string path, ParticipantsView p)
        {
            if (!File.Exists(path))
                return;

            using (StreamWriter fs = new StreamWriter(path))
            {
                fs.Write(JsonConvert.SerializeObject(p));
            }

        }

        public static void Add(string path, string name)
        {
            ParticipantsView participants = Read(path);
            participants.ListParticipants.Add(name);
            Write(path, participants);
        }
    }
}

