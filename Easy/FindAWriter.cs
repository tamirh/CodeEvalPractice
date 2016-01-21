namespace CodeEvalPractice.Easy
{
    class FindAWriter
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
                if (line == null || line.Length < 2)
                    continue;

                string[] paramVals = line.Split('|');
                string source = paramVals[0];

                string[] keyStrings = paramVals[1].Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                int[] keys = System.Array.ConvertAll(keyStrings, System.Int32.Parse);

                char[] output = new char[keys.Length];
                for (int i=0; i<keys.Length; ++i)
                {
                    output[i] = source[keys[i]-1];
                }

                System.Console.WriteLine(output);
            }
        }
    }
}
