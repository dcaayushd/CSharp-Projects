// using System.Text;
class MainProgram
{
    public static void Main(String[] ___)
    {
        // int marks = 51;
        Console.Write("Enter Your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());
        #pragma warning disable
        bool HasPassedTheExam = false;
        if(marks>= 95 && marks <100){
            HasPassedTheExam = true;
            Console.WriteLine("You are among the top Students");
        }
        if(marks>= 80 && marks < 95){
            HasPassedTheExam = true;
            Console.WriteLine("You have passed the exam with distinction");
        }
        else if(marks>= 32 && marks <80){
            HasPassedTheExam = true;
            Console.WriteLine("You have passed the exam");
        }
        else if(marks>=0 && marks <32){
            HasPassedTheExam = false;
            Console.WriteLine("You have failed the exam");
        }
        else{
            Console.WriteLine("Invalid marks entered");
        }
    }
}
