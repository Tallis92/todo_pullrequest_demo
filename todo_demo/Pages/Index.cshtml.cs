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
            TodoItems = Functions.GetList();
            TodoItem = new Models.TodoItem();

            if (TodoItems == null)
            {
                TodoItems = new List<Models.TodoItem>();
            }
           
        }
        public IActionResult OnPost()
        {
            TodoItems = Functions.GetList();
            TodoItems.Add(TodoItem);
            Functions.UpdateList(TodoItems);

            return Page();
        }
    }
}
