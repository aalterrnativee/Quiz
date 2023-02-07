using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private GetData _getData;

        public IndexModel(ILogger<IndexModel> logger,
            GetData data)
        {
            _logger = logger;
            _getData = data;
        }

        public void OnGet()
        {
            _getData.FullName();
        }
    }
}