using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CV.Models;

namespace CV.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesCVContext _context;

        public DeleteModel(RazorPagesCVContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CvModel = await _context.CvModel.FindAsync(id);

            if (CvModel != null)
            {
                _context.CvModel.Remove(CvModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}