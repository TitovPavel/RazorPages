using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class participants_list : PageModel
    {
        public ParticipantsView participantsView = new ParticipantsView();

        public void OnGet()
        {
            participantsView = Participants.Read(Participants.participantsFile);
        }
    }
}