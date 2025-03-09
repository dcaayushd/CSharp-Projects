namespace CodePlusCircle
{
    interface IPerson
    {
        string? Who();
    }



    class Employee : IPerson
    {
        public string? Who()
        {
            // return ToString()?.Split('.')[^1];
            return "Employee";
        }
    }
    class Manager : IPerson
    {
        public string? Who()
        {
            // return "Manager";
            return ToString()?.Split('.')[^1];
        }
    }

    class Person
    {
        virtual public string? Who()
        {
            return "Person";
        }
    }

    class TestEmployee : Person
    {
        public override string? Who()
        {
            return "Test Employee";
        }
    }
    class MainProgram
    {
        static void Main(string[] ___)
        {
            Employee employee = new();
            Console.WriteLine(employee.Who());
            Manager manager = new();
            Console.WriteLine(manager.Who());

            IPerson person = new Employee();
            // Console.WriteLine(person.Who());
            person = new Manager();
            Console.WriteLine(person.Who());

            Person person1 = new TestEmployee();
            Console.WriteLine(person1.Who());
            person1 = new Person();
            Console.WriteLine(person1.Who());


        }
    }

}