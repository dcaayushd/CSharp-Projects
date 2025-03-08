using static System.Linq.Enumerable;
class MainProgram
{
    static void Main(string[] ___)
    {
        // Person person = new();
        // person.name = "Aayush";
        // person.age = 23U;
        Person person = new()
        {
            name = "Aayush",
            age = 23U
        };

        Console.WriteLine(person.name);
        Console.WriteLine(person.age);

    }
}

class Person{
    public string? name;
    public uint age;

}
