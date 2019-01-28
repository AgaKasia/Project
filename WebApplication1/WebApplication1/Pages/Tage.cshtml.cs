using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class TageModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int? Number2 { get; set; }

        [BindProperty]
        public double Number3 { get; set; }

        [BindProperty]
        public double? Number4 { get; set; }

        [BindProperty]
        public decimal Number5 { get; set; }

        [BindProperty]
        public decimal? Number6 { get; set; }

        [BindProperty]
        public float Number7 { get; set; }

        [BindProperty]
        public float? Number8 { get; set; }

        [BindProperty]
        public string String1 { get; set; }

        [BindProperty]
        public DateTime Time1 { get; set; }

        [BindProperty]
        public DateTime? Time2 { get; set; }

        [BindProperty]
        public bool IsContactAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Message = String.Format("Your choice of season is {0}", Season);
        }

    }
}
