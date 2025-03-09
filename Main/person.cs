abstract class Person
{
    public String Name = string.Empty;
    public int Age = 0;

    abstract public void Speak();
}

class Doctor : Person
{
    string degree = string.Empty;
    public override void Speak(){
        Console.WriteLine("Doctor can speak");
    }
}

class Patient : Person
{
     public override void Speak(){
        Console.WriteLine("Patient can speak");
    }

}
