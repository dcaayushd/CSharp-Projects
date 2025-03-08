using Company;
class MainProgram
{
    static void Main(string[] ___)
    {
        Person person = new();
        Person person1= new();

        Console.WriteLine(person.name);
        Console.WriteLine(person1.name);
        Console.WriteLine(person.age);
        person.Speak();
        person.Breathe();
        person.Eat();

    }
}

