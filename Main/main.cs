// using System.Text;
class MainProgram
{
    public static void Main(string[] ___)
    {
        object thing = "Something";
        // thing = 12;
        // thing = 12.435f;
        // Console.WriteLine(thing);

        //Boxing and Unboxing
        string str = (string)thing;


        // int number;
        // if (int.TryParse(thing.ToString(), out number))
        // {
            ////! Some int code
        // }
        // if (thing is int number)
        // {
            ////! Some int stuff code
        // }

        if(thing is int){
            int number = (int)thing;
        }
        else if (thing is string){
            Console.WriteLine("string");
            //do string stuff code
        }

    }
}
