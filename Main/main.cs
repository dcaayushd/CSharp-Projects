using Company;
class MainProgram
{
    static void Main(string[] ___)
    {
        // // Person person = new();
        // // person.name = "Aayush";
        // // person.age = 23U;
        // Person person = new()
        // {
        //     name = "Aayush",
        //     age = 23U,
        // };

        // Console.WriteLine(person.name);
        // Console.WriteLine(person.age);
        // person.Speak();
        // person.Breathe();
        // person.Eat();

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

// class Person{
//     public string? name;
//     public uint age;

//     public void Speak(){
//         Console.WriteLine($"Yes, {name} who is {age} years old can speak.");
//     }
//     public void Breathe(){
//         Console.WriteLine($"Yes, {name} who is {age} years old can breathe.");
//     }
//     public void Eat(){
//         Console.WriteLine($"Yes, {name} who is {age} years old can eat.");
//     }

// }
