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
        public List<Models.TodoItem> TodoItems { get; set; }

        public void OnGet()
        {
            if (TodoItems == null)
            {
                TodoItems = new List<Models.TodoItem>();
            }
        }
        public IActionResult OnPost()
        {
            if (TodoItems == null)
            {
                TodoItems = new List<Models.TodoItem>();
            }

            TodoItems.Add(TodoItem);
            return Page();
        }
    }
}
