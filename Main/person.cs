namespace Company
{
    public class Person
    {

        public Person()
        {
            Console.WriteLine("Person() Called");
            _name = "undefined";
            Age = 0U;
        }
        #pragma warning disable
        public Person(string name):this()
        {
            Console.WriteLine("Person(string name) Called");
            Name = name;
        }
        public Person(string name, uint age ) :this()
        {
            Console.WriteLine("Person(string name, uint age) Called");
            Name = name;
            Age = age;
        }
        string _name;
        public string Name
        {
            set
            {

                _name = (value.Equals(string.Empty) || value == null) ? _name : value;

            }
            get
            {
                return _name;
            }
        }

        public uint Age;

        public void Speak()
        {
            Console.WriteLine($"Yes, {Name} who is {Age} years old can speak.");
        }
        public void Breathe()
        {
            Console.WriteLine($"Yes, {Name} who is {Age} years old can breathe.");
        }
        public void Eat()
        {
            Console.WriteLine($"Yes, {Name} who is {Age} years old can eat.");
        }

    }
}