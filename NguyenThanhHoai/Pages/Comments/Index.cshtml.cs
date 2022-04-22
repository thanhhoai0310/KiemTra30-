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
    public class IndexModel : PageModel
    {
        private readonly MyDB _context;

        public IndexModel(MyDB context)
        {
            _context = context;
        }

        public IList<Comments> Comments { get;set; }

        public async Task OnGetAsync()
        {
            Comments = await _context.Comment.ToListAsync();
        }
    }
}
