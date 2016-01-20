namespace CodeEvalPractice.Easy
{
    class SelfDescribingNumbers
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

                if (IsSelfDescribing(line))
                {
                    System.Console.WriteLine("1");
                }
                else
                {
                    System.Console.WriteLine("0");
                }
            }
        }

        static bool IsSelfDescribing(string num)
        {
            int[] expectedDigits = new int[10];
            int[] actualDigits = new int[10];

            for (int i=0; i < num.Length; ++i)
            {
                int value = num[i] - '0';
                actualDigits[value]++;
                expectedDigits[i] = value;
            }

            for (int i=0; i<10; ++i)
            {
                if (expectedDigits[i] != actualDigits[i])
                    return false;
            }

            return true;
        }
    }
}
