namespace CodeEvalPractice.Easy
{
    class HexToDecimal
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

                line = line.Trim();

                int value = 0;
                for (int i = line.Length - 1; i >= 0; --i)
                {
                    char c = line[i];
                    int digit = c > '9' ? c - 'a' + 10 : c - '0';
                    int hexPos = line.Length - i - 1;
                    value += digit << hexPos * 4;
                }

                System.Console.WriteLine(value);
            }
        }
    }
}
