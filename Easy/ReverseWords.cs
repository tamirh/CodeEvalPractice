namespace CodeEvalPractice.Easy
{
    // https://www.codeeval.com/open_challenges/8/
    class ReverseWords
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

                string[] words = line.Split();
                System.Array.Reverse(words);

                string reversed = string.Join(" ", words);

                System.Console.WriteLine(reversed);
            }
        }
    }
}
