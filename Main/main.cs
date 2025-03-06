using System.Text;
class MainProgram
{
    public static void Main(String[] ___)
    {     
        // string str = "This is some data about";
        // str += ". and this is more about";
        // // str += "";
        // str += String.Empty;
        // Console.WriteLine(str);

        StringBuilder str = new ("This is string") ;
        str.Append(" builder.");
        str.Append(" and this is more about");
        str.Append(" string builder.");
        str.AppendFormat("this is a new {0} for string builder", "placeholder");
        str.AppendLine();
        str.Clear();

        Console.WriteLine(str);
        Console.WriteLine($"Length: {str.Length}");
        Console.WriteLine($"Capacity: {str.Capacity}");

    }
}
