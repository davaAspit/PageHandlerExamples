using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PageHandlerExamples.Pages
{
    public class PageHandlerTestModel : PageModel
    {
        [BindProperty]
        public string Text { get; set; }
        public string Message { get; set; }
        public string SubmitButtonValue { get; set; }
        public string PageHandler { get; set; }
        public string PostMessage { get; set; }
        public void OnGet()
        {
            Message = "Kald via OnGet";
            SubmitButtonValue = "Gem tekst";
            PageHandler = "";
        }

        public void OnPost()
        {
            PostMessage = $"OnPost med teksten: {Text}";
        }

        public void OnGetEdit()
        {
            Message = "Kald via OnGetEdit";
            SubmitButtonValue = "Opdater tekst";
            PageHandler = "Edit";
        }

        public void OnPostEdit()
        {
            PostMessage = $"OnPostEdit med teksten: {Text}";
        }

    }
}