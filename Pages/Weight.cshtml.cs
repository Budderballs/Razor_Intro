using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor
{
    public class WeightModel : PageModel
    {
        public int convertedWeight;
        [BindProperty]
        public int weight { get; set; }
        [BindProperty]
        public int weightType { get; set; }

        public void OnPost()
        {

            if (weightType == 1)
            {
                convertedWeight = weight * 16; // P to O
            }
            else if (weightType == 2)
            {
                convertedWeight = weight / 16; // O to P
            }
            else if (weightType == 3)
            {
                convertedWeight = weight / 454; // G to P
            }
            else if (weightType == 4)
            {
                convertedWeight = weight / 453592; // M to P
            }
        }
    }
}
