using BlazorTasks.Models;

namespace BlazorTasks.Interfaces
{
    public interface ITodoService
    {
        public Task<List<TodoItem>> GetTodoItemsAsync();
        public Task AddTaskAsync(string Title);
        public Task RemoveAsync(int Id);
        public Task DoneAsync(int Id);
    }
}
