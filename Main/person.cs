namespace Company
{
    public class Person
    {

        public Person()
        {
            Console.WriteLine("Person() Called");
            _name = "undefined";
            age = 0U;
        }
        string _name;
        public string name
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