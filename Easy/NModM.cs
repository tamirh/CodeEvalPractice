namespace CodeEvalPractice.Easy
{
    class NModM
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

                string[] paramVals = line.Split(',');

                int n = System.Int32.Parse(paramVals[0]);
                int m = System.Int32.Parse(paramVals[1]);

                int div = n / m;
                int mod = n - m * div;
                
                System.Console.WriteLine(mod);
            }
        }
    }
}
