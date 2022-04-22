using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenThanhHoai.Models;

namespace NguyenThanhHoai.Pages_Comments
{
    public class DeleteModel : PageModel
    {
        private readonly MyDB _context;

        public DeleteModel(MyDB context)
        {
            _context = context;
        }

        [BindProperty]
        public Comments Comments { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Comments = await _context.Comment.FirstOrDefaultAsync(m => m.ID == id);

            if (Comments == null)
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

            Comments = await _context.Comment.FindAsync(id);

            if (Comments != null)
            {
                _context.Comment.Remove(Comments);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
