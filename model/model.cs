public class Model
{
  // Define getters and setters
  public string? Name { get; set; }
  public int Age { get; set; }

  // Create model to hold name and age
  public Model(string name, int age)
  {
    Name = name;
    Age = age;
  }

  // Override the ToString() method, to utilize in View
  public override string ToString()
  {
    return $"Name: {Name} \nAge: {Age}";
  }
}