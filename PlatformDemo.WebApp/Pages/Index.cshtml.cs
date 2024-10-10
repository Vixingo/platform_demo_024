using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Collections.Generic;
using PlatformDemo.ClassLibrary;

namespace PlatformDemo.WebApp.Pages
{
    public class IndexModel : PageModel
    {

      ApplicationDbContext _context;

      public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<ServicePlan> ServicePlans { get;set; }  = default!;
        public void OnGet()
        {
        ServicePlans = _context.ServicePlans.ToList();
         }
    }
}
