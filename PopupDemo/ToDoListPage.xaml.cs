using PopupDemo.Models;

namespace PopupDemo;

public partial class ToDoListPage : ContentPage
{
	public List<ToDo> todos = new List<ToDo>();

	public ToDoListPage()
	{
		todos.Add(
			new ToDo() { Id = 1, Task = "Go Shopping", IsCompleted = false });
		todos.Add(
			new ToDo() {Id=2, Task="Fuel Car", IsCompleted=true }
			);
		InitializeComponent();
	}
}