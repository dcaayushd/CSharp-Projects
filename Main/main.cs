using Company;
class MainProgram
{
    static void Main(string[] ___)
    {
        Person person = new();
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);

        Person person1= new("Shyam");
        Console.WriteLine(person1.Name);
        Console.WriteLine(person1.Age);

        Person person2= new("Ram", 34U);
        Console.WriteLine(person2.Name);
        Console.WriteLine(person2.Age);
        person.Speak();
        person.Breathe();
        person.Eat();

    }
}

