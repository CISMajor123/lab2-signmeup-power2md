using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab2_signmeup_power2md.Pages
{
    public class IndexModels : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModels(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
