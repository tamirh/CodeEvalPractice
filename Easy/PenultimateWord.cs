namespace CodeEvalPractice.Easy
{
    class PenultimateWord
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
                if (line == null || line.Length < 1)
                    continue;

                // Find the second to last word in a string
                // Could do it with Split(), but this is a "C" style answer

                int curBegin = 0;
                int curEnd = FindWordEnd(line, 0);
                int nextBegin = FindWordBegin(line, curEnd);
                int nextEnd = FindWordEnd(line, nextBegin);

                while(nextEnd < line.Length)
                {
                    curBegin = nextBegin;
                    curEnd = nextEnd;

                    nextBegin = FindWordBegin(line, curEnd);
                    nextEnd = FindWordEnd(line, nextBegin);
                }

                System.Console.WriteLine(line.Substring(curBegin, curEnd - curBegin));
            }
        }

        static bool WordChar(char c)
        {
            return (c != ' ');
        }

        static int FindWordBegin(string line, int start)
        {
            int i;
            for (i = start + 1; i < line.Length; ++i)
            {
                if (WordChar(line[i]))
                    return i;
            }

            return i;
        }

        static int FindWordEnd(string line, int start)
        {
            int i;
            for (i = start + 1; i < line.Length; ++i)
            {
                if (!WordChar(line[i]))
                    return i;
            }

            return i;
        }
    }
}
