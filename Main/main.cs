// using System;
class MainProgram
{
    public static void Main(String[] ___)
    {
        string str = "This is a test program";
        string str2 = "TESTING LowER STRING";
        string str3 = "    This is   a  test program   ";
        string str4 = "This,is,a,test,program,";
        int length = str.Length;
        string upper = str.ToUpper();
        string lower = str2.ToLower();
        string rplc = str.Replace('s', '5');
        string insrt = str.Insert(0, "Hey, ");
        string insrt1 = str.Insert(22, " guys.");
        int indx = str.IndexOf('s');
        int indx1 = str.IndexOf("test");
        int Lstindx = str.LastIndexOf('s');
        bool endWith = str.EndsWith('s');
        bool endWith1 = str.EndsWith("program");
        bool startW = str.StartsWith('a');
        // bool eq = str == "";
        bool eq = str.Equals("This is a test program");
        bool contains = str.Contains("st");
        bool contains1 = str.Contains(" st ");
        string trm = str3.Trim();
        string trm1 = str3.TrimStart();
        string trm2 = str3.TrimEnd();
        string substr = str.Substring(0);
        string substr1 = str.Substring(2, 7);
        string concat = str + " in C#";
        string[] splt = str4.Split(',');
        string[] splt2 = str4.Split("");

        Console.WriteLine(str);
        Console.WriteLine(length);
        Console.WriteLine(upper);
        Console.WriteLine(lower);
        Console.WriteLine(rplc);
        Console.WriteLine(insrt);
        Console.WriteLine(insrt1);
        Console.WriteLine(indx);
        Console.WriteLine(indx1);
        Console.WriteLine(Lstindx);
        Console.WriteLine(endWith);
        Console.WriteLine(endWith1);
        Console.WriteLine(startW);
        Console.WriteLine(eq);
        Console.WriteLine(contains);
        Console.WriteLine(contains1);
        Console.WriteLine(trm);
        Console.WriteLine(trm1);
        Console.WriteLine(substr);
        Console.WriteLine(substr1);
        Console.WriteLine(concat);

        foreach(String s in splt){
            Console.WriteLine(s);
        }

        foreach(String spl in splt2){
            Console.WriteLine(spl);
        }
    }
}
