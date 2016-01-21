namespace CodeEvalPractice.Easy
{
    class SwapCase
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
                for (int i = 0; i < chars.Length; ++i)
                {
                    if (System.Char.IsUpper(chars[i]))
                    {
                        chars[i] = System.Char.ToLower(chars[i]);
                    } else if (System.Char.IsLower(chars[i]))
                    {
                        chars[i] = System.Char.ToUpper(chars[i]);
                    }
                }

                System.Console.WriteLine(chars);
            }
        }
    }
}
