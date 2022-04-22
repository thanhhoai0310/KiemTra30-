using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace NguyenThanhHoai.Pages;

public class IndexModel : PageModel
{
    // private readonly ILogger<IndexModel> _logger;

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

    private readonly MyDB _context;

    public IndexModel(MyDB context)
    {
        _context = context;
    }

    public IList<NguyenThanhHoai.Models.News> News { get; set; }

    public async Task OnGetAsync()
    {
        News = await _context.News.ToListAsync();
    }

}
