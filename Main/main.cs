namespace CodePlusCircle
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        string GetName();

    }

    interface IManager
    {
        string Role { get; set; }
    }

    class Employee : IPerson, IManager
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string GetName()
        {
            return Name;
        }
        public string Role { get; set; } = string.Empty;
    }
    class MainProgram
    {
        static void Main(string[] ___)
        {
            // Employee employee = new ();
            // employee÷.Name = "Shyam";
            Employee employee = new()
            {
                Name = "Shyam",
            };
            Console.WriteLine(employee.GetName());
        }
    }

}