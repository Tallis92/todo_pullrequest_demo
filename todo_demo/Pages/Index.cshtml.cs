using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace todo_demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Models.TodoItem TodoItem { get; set; }

       
        public static List<Models.TodoItem> TodoItems { get; set; } = new List<Models.TodoItem>();

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            if (TodoItem != null)
            {
                TodoItems.Add(TodoItem);
            }

            return Page();
        }
    }
}
