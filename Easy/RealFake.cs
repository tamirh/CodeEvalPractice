namespace CodeEvalPractice.Easy
{
    class RealFake
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

                string ccardnum = line.Replace(" ", string.Empty);
                if (IsCCardReal(ccardnum))
                {
                    System.Console.WriteLine("Real");
                }
                else
                {
                    System.Console.WriteLine("Fake");
                }
            }
        }

        static bool IsCCardReal(string ccardnum)
        {
            int sum = 0;
            for (int i=0; i<ccardnum.Length; ++i)
            {
                int digit = System.Int32.Parse(ccardnum.Substring(i, 1));
                if (i%2 == 0)
                {
                    sum += 2 * digit;
                }
                else
                {
                    sum += digit;
                }
            }

            if (sum % 10 != 0)
                return false;

            return true;
        }
    }
}
