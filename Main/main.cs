namespace CodePlusCircle
{
    class MainProgram
    {
        // static bool isOdd(int n)
        // {
        //     return n % 2 == 1;
        // }
        // static bool isEven(int n)
        // {
        //     return n % 2 == 0;
        // }
        static void Main(string[] ___)
        {
            // var isEven = (int n) => n % 2 == 0;
            // Console.WriteLine(isEven(6));

            ////! Generic Keyword
            Func<int, bool> isOdd = (int n) => n % 2 == 1;

            var isEven = (int n) =>
            {
                Console.WriteLine("Inside the lambda");
                return n % 2 == 0;
            };
            Console.WriteLine(isEven(6));
            Console.WriteLine(isOdd(6));


            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // List<int> odds = ints.Where(isOdd).ToList();
            // List<int> evens = ints.Where(isEven).ToList();
            ////! Instead of using above use below
            ////! List<int>odds = (List<int>)ints.Where((int n) => n % 2 == 1);
            ////! List<int>evens = (List<int>)ints.Where((int n) => n % 2 == 0);
            List<int> odds = ints.Where((int n) => n % 2 == 1).ToList();
            List<int> evens = ints.Where((int n) => n % 2 == 0).ToList();
            Console.WriteLine("Odd Numbers from the list ints are:");
            foreach (var i in odds)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Even Numbers from the list ints are:");
            foreach (var i in evens)
            {
                Console.WriteLine(i);
            }

        }
    }
}