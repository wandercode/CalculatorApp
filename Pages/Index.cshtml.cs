using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public double _Area;
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        
        }
        public void OnPost()
        {
           double cash=Double.Parse(Request.Form["amount"]);
            int time=Int32.Parse(Request.Form["period"]);
            double rate=Double.Parse(Request.Form["interest"]);
            double increase=cash*rate*time;
            double submit=cash+(increase/100);
            ViewData["Amount"]=submit;
        }
    }
}
