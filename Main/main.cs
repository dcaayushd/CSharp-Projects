namespace CodePlusCircle
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            //Some Custom Exception Codes
        }

    }
    class MainProgram
    {
        static void Main(string[] ___)
        {
            try
            {
                bool failure = true; //Based on real data source
                // bool failure = false; //Based on real data source
                bool otherCondition = true; //Based on real data source
                if (failure)
                {
                    throw new CustomException("Some kind of exception occurred");
                }
                else if (otherCondition)
                {
                    throw new ArgumentException("Invalid arguments");
                }
                Console.WriteLine("Processing the data...");

            }

            catch (ArgumentException e)
            {
                throw new Exception($"{e.Message} Occurred");
            }
            catch (CustomException e)
            {
                throw new Exception($"{e.Message} Occurred");
            }

            finally
            {
                // Even if there is exception or no exception this has to be executed 
                Console.WriteLine("Finally freeing the resources...");
            }
        }
    }
}