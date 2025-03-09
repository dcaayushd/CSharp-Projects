abstract class Person
{
    // static public ulong Count = 0UL;
    public static ulong Count = 0UL;
    // public int age = 0;
    public Person()
    {
        Count++;
    }

    // static public void Talk(Person person)
    // {
    //     person.age++;
    //     Console.WriteLine("The person is talking");
    // }
    static public void Talk()
    {
        Console.WriteLine("The person is talking");
    }
}

class Doctor : Person
{
    public Doctor() : base() { }
}

class Patient : Person

{
    public Patient() : base() { }
}
