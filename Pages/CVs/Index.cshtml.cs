using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CV.Models;

namespace CV.Pages.CVs
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCVContext _context;

        public IndexModel(RazorPagesCVContext context)
        {
            _context = context;
        }

        public IList<CvModel> CvModel { get;set; }

        public async Task OnGetAsync()
        {
            CvModel = await _context.CvModel.ToListAsync();
        }
    }
}
