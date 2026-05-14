using BlazorTasks.Interfaces;
using BlazorTasks.Models;

namespace BlazorTasks.Services
{
    public class TodoServices : ITodoService
    {
        //private list to store the todo items in memory
        private List<TodoItem> TodoListItems { get; set; } = new List<TodoItem>();

        public async Task AddTaskAsync(string Title)
        {
            var newItem = new TodoItem
            {
                Title = Title,
                IsDone = false,
                ID = TodoListItems.Count > 0 ? TodoListItems.Count+ 1 : 1
            };
            TodoListItems.Add(newItem);
        }

        public async Task DoneAsync(int Id)
        {
            throw new NotImplementedException();
        }
        
        public async Task RemoveAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            return await Task.FromResult(TodoListItems);
        }
    }
}
