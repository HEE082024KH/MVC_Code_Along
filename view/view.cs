public class View
{
  public void Display(Model model)
  {
    Console.WriteLine(model.ToString());
  }

  public void DispayMessage(string message)
  {
    Console.WriteLine($"{message}");
  }
}