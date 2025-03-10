// // using System.Numerics;

// namespace CodePlusCircle
// {
//     class MainProgram
//     {
//         static void Main(string[] ___)
//         {
//             // List<int > ints = [1, 2, 3, 4, 5, 6 , 7, 8, 9, 10, 11, 12, 13, 14, 15];
//             // Console.WriteWriteLine($"THe number of integers are: {ints.Count}");
//             // foreach (var each in ints){
//             //     Console.WriteLine(each);
//             // }

//             // List<int > ints = [];
//             List<int> ints = [1, 2, 3, 4, 5];

//             // ints.Add(12);

//             // ints.ForEach((int n)=>{
//             //     n+=12;
//             //     Console.WriteLine(n);
//             // });

//             // ints.Find((int n)=> n==2);
//             // ints.Contains(12);
//             // ints.AddRange([6,7,8,9,10,11]);
//             List<int> other = [6, 7, 8, 9, 10, 11];
//             ints.AddRange(other);

//             Console.WriteLine($"THe number of integers are: {ints.Count}");
//             foreach (int i in ints)
//             {
//                 Console.WriteLine(i);
//             }

//             Dictionary<string, List<int>> grades = new(){
//                 {"me", [1,1,1]},
//                 {"you", [2,2,2]},
//             };

//             grades["him"] = [3, 3, 3];
//             // if (grades.ContainsKey("him"))
//             // {
//             //     var hisGrades = grades["him"];
//             // }
//             if (grades.TryGetValue("him", out List<int>? hisGrades))
//             {
//                 foreach (var grade in hisGrades)
//                 {
//                     Console.WriteLine(grade);
//                 }
//             }

//             HashSet<string> names = ["me", "me", "you"];
//             foreach (var name in names)
//             {
//                 Console.WriteLine(name);
//             }

//             Queue<string> strings = [];
//             strings.Enqueue("");
//             strings.Dequeue();

//             Stack<int> stack = [];
//             stack.Push(22);
//             stack.Pop();
//             foreach (var num in stack)
//             {
//                 Console.WriteLine(num);
//             }

//             LinkedList<int> list = [];

//             list.AddFirst(12);
//             list.AddLast(13);
//             foreach (var num in list)
//             {
//                 Console.WriteLine(num);
//             }
//         }
//     }
// }

 List<int> ints = [1, 2, 3, 4, 5];

            // ints.Add(12);

            // ints.ForEach((int n)=>{
            //     n+=12;
            //     Console.WriteLine(n);
            // });

            // ints.Find((int n)=> n==2);
            // ints.Contains(12);
            // ints.AddRange([6,7,8,9,10,11]);
            List<int> other = [6, 7, 8, 9, 10, 11];
            ints.AddRange(other);

            Console.WriteLine($"THe number of integers are: {ints.Count}");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Dictionary<string, List<int>> grades = new(){
                {"me", [1,1,1]},
                {"you", [2,2,2]},
            };

            grades["him"] = [3, 3, 3];
            // if (grades.ContainsKey("him"))
            // {
            //     var hisGrades = grades["him"];
            // }
            if (grades.TryGetValue("him", out List<int>? hisGrades))
            {
                foreach (var grade in hisGrades)
                {
                    Console.WriteLine(grade);
                }
            }

            HashSet<string> names = ["me", "me", "you"];
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Queue<string> strings = [];
            strings.Enqueue("");
            strings.Dequeue();

            Stack<int> stack = [];
            stack.Push(22);
            stack.Pop();
            foreach (var num in stack)
            {
                Console.WriteLine(num);
            }

            LinkedList<int> list = [];

            list.AddFirst(12);
            list.AddLast(13);
            foreach (var num in list)
            {
                Console.WriteLine(num);
            }
        