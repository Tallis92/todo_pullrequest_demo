namespace todo_demo
{
    public class Functions
    {
        public static List<Models.TodoItem> TodoItems { get; set; } = new List<Models.TodoItem>();

        public static List<Models.TodoItem> CreateList()
        {
            TodoItems = new List<Models.TodoItem>();

            return TodoItems;
        }

        public static List<Models.TodoItem> UpdateList(List<Models.TodoItem> list)
        {
            TodoItems.AddRange(list);

            return TodoItems;
        }

        public static List<Models.TodoItem> GetList()
        {
            return TodoItems;
        }
    }
}
