using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Moment1.Pages
{
    public class RazorModel : PageModel
    {
        public List<string> courses { get; set; }

        private readonly ILogger<RazorModel> _logger;

        public RazorModel(ILogger<RazorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public List<string> GetCourses()
        {
            var course = new List<string>
            {
                "DT084G, Introduktion till programmering i JavaScript",
                "DT057G, Webbutveckling I",
                "DT163G, Digital bildbehandling för webb",
                "GD008G, Typografi och form för webb",

                "DT003, Databaser",
                "DT152G, Webbdesign för CMS",
                "DT093G, Webbutveckling II",
                "JavaScriptbaserad webbutveckling",

                "IK060G, Projektledning",
                "DT173G, Webbutveckling III",
                "DT068G, Webbanvändbarhet",
                "DT071G, Programmering i C#.NET"
            };
            return course;
        }
 
    }
}
