using System.Numerics;
// class Vector<T, T2> where T : INumber <T> {
//     T data; //int data
//     T more;
// }

// class MainProgram{
//     Vector<int, float> vector = new();
//     Vector<double, string> vector2 = new();
// }


//Another code example 1

//     namespace CodePlusCircle
// {
//     class MainProgram
//     {
//         static void Main(string[] ___)
//         {
//             #pragma warning disable
//             T DoubleIt<T>(T number)
//             {
//                 return (dynamic)number * 2;
//             }
//             var twice = DoubleIt(12.4m);
//             Console.WriteLine(twice);
//         }
//     }    
// }

//Another code example 2

namespace CodePlusCircle
{
    class MainProgram
    {
        static void Main(string[] ___)
        {
            T DoubleIt<T>(T number) where T : INumber <T>
            {
                return (dynamic)number * 2;
            }
            var twice = DoubleIt(12.4);
            Console.WriteLine(twice);
        }
    }    
}