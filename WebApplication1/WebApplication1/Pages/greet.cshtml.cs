using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class greetModel : PageModel
    {
        public string Massage { get; set; } = "Hello!";


        public void OnGet()
        {
            if (DateTime.Now.Hour >= 12)
            {
                Massage = "Good Afternoon";

            }
            else
            {
                Massage = " Good Mornig";
            }

        }
    }
}