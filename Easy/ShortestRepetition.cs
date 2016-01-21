namespace CodeEvalPractice.Easy
{
    class ShortestRepetition
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
                string line = reader.ReadLine().Trim();
                if (line == null)
                    continue;

                System.Console.WriteLine(FindSmallestRepitition(line));
            }
        }

        static int FindSmallestRepitition(string line)
        {
            // Try all possible repetition lengths, starting from smallest
            for (int i = 1; i < line.Length; ++i)
            {
                if (IsRepitition(line, i))
                {
                    return i;
                }
            }

            return line.Length;
        }

        static bool IsRepitition(string line, int repLen)
        {
            // If it's not divisible by the possible length, it's not possible
            if (line.Length % repLen != 0)
                return false;

            // Go over the string in repLen increments and check they're the same 
            int index = 0;
            while (index < line.Length)
            {
                for (int i=0; i<repLen; ++i)
                {
                    if (line[i] != line[index])
                        return false;

                    ++index;
                }
            }

            return true;
        }
    }
}
