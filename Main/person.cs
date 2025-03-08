namespace Company
{
        public class Person
    {
        public string? name;
        public uint age;

        public void Speak()
        {
            Console.WriteLine($"Yes, {name} who is {age} years old can speak.");
        }
        public void Breathe()
        {
            Console.WriteLine($"Yes, {name} who is {age} years old can breathe.");
        }
        public void Eat()
        {
            Console.WriteLine($"Yes, {name} who is {age} years old can eat.");
        }

    }
}