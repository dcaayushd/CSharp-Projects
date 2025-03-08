using Company;
class MainProgram
{
    static void Main(string[] ___)
    {
        Person person = new()
        {
            name = "Aayush",
            age = 23U,
        };

        Console.WriteLine(person.name);
        Console.WriteLine(person.age);
        person.Speak();
        person.Breathe();
        person.Eat();

    }
}

