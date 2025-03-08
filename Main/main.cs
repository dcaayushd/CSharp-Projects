using static System.Linq.Enumerable;
class MainProgram
{
    static void Main(string[] ___)
    {

        bool canVote;
        int age = 18;
        // if (age >= 18)
        // {
        //     canVote = true;
        // }
        // else
        // {
        //     canVote = false;
        // }

        canVote = age >= 18 ? true : false;

        string can;
        can = canVote ? "YES" : "No";
        Console.WriteLine(can);

        //Another
        bool vote = true;

        // if(vote){
        //     Foo("YES");
        // }
        // else{
        //     Foo("NO");

        // }
        Foo(vote ? "YES" : "NO");
        string str = vote ? "Yes" : 10 < 4 ? "Something" : 100 < 40 ? "More" : "No";

    }

    static void Foo(string s)
    {
        Console.WriteLine(s);
    }

}
