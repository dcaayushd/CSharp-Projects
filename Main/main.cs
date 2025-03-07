// using System.Text;
class MainProgram
{
    public static void Main(string[] ___)
    {
        // // string command = "run";
        // string command = "";

        // switch (command)
        // {
        //     case "run":
        //         Console.WriteLine("Running...");
        //         break;

        //     case "stop":
        //         Console.WriteLine("Stopped...");
        //         break;

        //     default:
        //         Console.WriteLine("Invalid command");
        //         break;
        // }

        Object thing = "Aayush";
        thing = 12;
        thing = null;

        switch (thing)
        {
            case int number:
                Console.WriteLine("The number is " + number);
                //do int stuff
                break;

            case string str:
                Console.WriteLine("The string is " + str);
                //do string stuff
                break;

            default:
                Console.WriteLine("Invalid!");
                break;
        }

    }
}
