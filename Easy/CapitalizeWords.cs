namespace CodeEvalPractice.Easy
{
    class CapitalizeWords
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

                char[] chars = line.ToCharArray();
                char prevChar = ' ';
                for (int i = 0; i < chars.Length; ++i)
                {
                    if (prevChar == ' ')
                    {
                        if (chars[i] >= 'a' && chars[i] <= 'z')
                            chars[i] = (char)(chars[i] + ('A' - 'a'));
                    }

                    prevChar = line[i];
                }

                System.Console.WriteLine(chars);
            }
        }
    }
}
