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
    public class DetailsModel : PageModel
    {
        private readonly MyDB _context;

        public DetailsModel(MyDB context)
        {
            _context = context;
        }

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
    }
}
