using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace netservice.Pages
{
    public class IndexModel : PageModel
    {  
        
        public string result;
        public async Task OnGetAsync()
        {       
         
                Helper h=new Helper();
            result=await h.GetMessage();

        }
    }
}
