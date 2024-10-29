namespace MVC_Code_Along;

class Program
{
    static void Main(string[] args)
    {
        Model model = new("Lars", 42);
        View view = new();
        Controller controller = new(model, view);

        // Use controller to test the program.
        controller.DisplayModel();
        // Check if controller mehtods work
        controller.UpdateName();
        controller.UpdateAge();
        // Display the model after it was updated
        controller.DisplayModel();
        Console.ReadLine();
    }
}
