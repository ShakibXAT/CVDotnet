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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesCVContext _context;

        public DetailsModel(RazorPagesCVContext context)
        {
            _context = context;
        }

        public CvModel CvModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CvModel = await _context.CvModel.FirstOrDefaultAsync(m => m.Id == id);

            if (CvModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
