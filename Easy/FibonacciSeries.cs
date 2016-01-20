namespace CodeEvalPractice.Easy
{
    class FibonacciSeries
    {
        static System.IO.StreamReader OpenInput(string[] args)
        {
            string filename;
            if (args == null || args.Length < 1)
            {
                filename = "./../../Easy/" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ".txt";
            }
            else
            {
                filename = args[0];
            }

            return System.IO.File.OpenText(filename);
        }

        public static void Main(string[] args)
        {
            System.IO.StreamReader reader = OpenInput(args);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                    continue;

                int fibIndex = System.Int32.Parse(line);
                System.Console.WriteLine(Fibonacci(fibIndex));
            }
        }

        static int Fibonacci(int index)
        {
            if (index <= 0)
                return 0;

            if (index <= 2)
                return 1;

            // holds {n, n-1, n-2} of the sequence
            // currently holds values to calc F(2) next
            int[] fib = new int[] { 1, 1, 0 };
            for( int i=2; i <= index; ++i)
            {
                fib[0] = fib[1] + fib[2];
                fib[2] = fib[1];
                fib[1] = fib[0];
            }

            return fib[0];
        }
    }
}
