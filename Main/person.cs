namespace Company
{
    public class Person
    {
        string _name;
        public string name
        {
            // set; get;

            set
            {
                // if (value.Equals(string.Empty) || value == null)
                // {
                //     _name = "🥹🥹🥹 ";
                // }
                // else
                // {
                //     _name = value;
                // }

                _name = (value.Equals(string.Empty) || value == null) ? "🥹🥹🥹 " : value;

            }
            get
            {
                return _name;
            }
        }



        // public readonly uint age; // This is readonly and can't be assigned
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