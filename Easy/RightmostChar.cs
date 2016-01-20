namespace CodeEvalPractice.Easy
{
    class RightmostChar
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
                if (line == null || line.Length < 3)
                    continue;

                string[] paramVals = line.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries);
                if (paramVals == null || paramVals.Length < 2)
                    continue;

                string s = paramVals[0];
                string t = paramVals[1];

                int index = s.LastIndexOf(t[0]);
                System.Console.WriteLine(index);
            }
        }
    }
}
