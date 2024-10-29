namespace MVC_Code_Along;

class Program
{
    static void Main(string[] args)
    {
        Model model = new("Lars", 42);
        View view = new();
        Controller controller = new(model, view);

        controller.DisplayModel();
    }
}
