// using System.Text;
class MainProgram
{
    public static void Main(String[] ___)
    {
        # pragma warning disable
        // string name = null; //from database
        //Normal Approach of checking for null
        // if (name == null)
        // {
        //     name.EndsWith("_");
        // }

        // Object Oriented Approach
        // name?.EndsWith("_");

        string name = "Aayush"; //from database


        string other = name ?? "Unknown";
        other?.Contains("");
        Console.WriteLine(other);
 
        // if(name != null) other = name;
        // else other = "Unknown";

        int? age = null; //from database

        int a = age as int? ?? 0;

        Console.WriteLine(a);

    }
}
