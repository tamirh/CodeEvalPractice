namespace CodeEvalPractice.Hard
{
    // https://www.codeeval.com/open_challenges/42/
    class UglyNumbers
    {
        static System.IO.StreamReader OpenInput(string[] args)
        {
            string filename;
            if (args == null || args.Length < 1)
            {
                filename = "./../../Hard/" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ".txt";
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

                int numUglies = 0;
                int incIndex = 0;
                char[] ops = new char[line.Length];
                while (ops[line.Length - 1] < 3)
                {
                    ops[incIndex]++;

                    if (ops)
                }
            }
        }

        static bool IsExpressionUgly(string s, char[] ops)
        {
            return false;
        }

        static bool IsUglyNumber(int num)
        {
            if (num == 0)
                return true;

            if (num % 2 == 0)
                return true;

            if (num % 3 == 0)
                return true;

            if (num % 5 == 0)
                return true;

            if (num % 7 == 0)
                return true;

            return false;
        }
    }
}
