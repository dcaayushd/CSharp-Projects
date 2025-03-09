namespace Company
{
    public class Person
    {
        public String Name = string.Empty;
        public int Age = 0;

        public void Speak(){
            Console.WriteLine($"{Name}, who is {Age} years old can speak ");
        }
    }

    class Doctor : Person{
        string degree = string.Empty;
    }

    class Patient : Person{

    }
}