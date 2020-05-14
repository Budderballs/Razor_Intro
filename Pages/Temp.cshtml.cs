using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor
{
    public class TempModel : PageModel
    {
        public int convertedTemp;

        [BindProperty]
        public int temp { get; set; }
        [BindProperty]
        public int ForCorCorF { get; set; }
        public void OnPost()
        {
            if (ForCorCorF == 1)
            {
                convertedTemp = ((temp - 32) * 5) / 9; // F to C
            }
            else if (ForCorCorF == 2)
            {
                convertedTemp = ((temp * 9) / 5) + 32; // C to F
            }
        }
    }
}
