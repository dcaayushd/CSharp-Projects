// using System;
class MainProgram
{
    public static void Main(String[] ___)
    {
        int age = 23;
        string name = "Aayush";
        string str = string.Format("Hi {0}!, You're {1} years old.", name, age); 
        Console.WriteLine(str);
        decimal price = 1235.89564m;
        string strp = string.Format("Toatl price: {0}", price);
        string strp1 = string.Format("Toatl price: {0:c}", price);
        Console.WriteLine(strp);
        Console.WriteLine(strp1);
    }
}
