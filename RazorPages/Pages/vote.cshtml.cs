using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class voteModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost(string name, string attend)
        {
            if(attend=="on")
            {
                Participants.Add(Participants.participantsFile, name);
            }
            return RedirectToPage("participants");
        }
    }
}