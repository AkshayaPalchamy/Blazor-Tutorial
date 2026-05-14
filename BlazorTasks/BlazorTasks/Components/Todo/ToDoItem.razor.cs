using BlazorTasks.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorTasks.Components
{
    public partial class ToDoItem: ComponentBase 
    {
        [Parameter]
        public TodoItem? TodoTask { get; set; }

        [Parameter]
        public EventCallback<int> OnDone { get; set; }

        [Parameter]
        public EventCallback<int> OnDelete { get; set; }
    }
}
