// using System;
class MainProgram{
    public static void Main(String[] ___){
        string str = "123";
        int num = int.Parse(str);
        Console.WriteLine(num);
        Console.WriteLine(num.GetType());
        
        string str1= "false";
        bool b1 = bool.Parse(str1);
        Console.WriteLine(b1);

        String str2 = "1234.577";
        double d1 = double.Parse(str2);
        Console.WriteLine(d1);
        Console.WriteLine(d1.GetType());

    }
}
