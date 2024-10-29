public class Controller
{
  // Inherit the Model and View classes, and creat the objects model and view
  Model _model;
  View _view;

  public Controller(Model model, View view)
  {
    _model = model;
    _view = view;
  }

  public void UpdateName()
  {
    Console.WriteLine("Write a new name");
    string? newName = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(newName))
    {
      Console.WriteLine("Name cannot be empty");
    }
    else
    {
      _model.Name = newName;
    }
  }

  public void UpdateAge()
  {
    Console.WriteLine("Write a new age");
    if (int.TryParse(Console.ReadLine(), out int newAge))
    {
      _model.Age = newAge;
    }
  }

  public void DisplayModel()
  {
    _view.Display(_model);
  }
}