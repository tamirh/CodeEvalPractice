namespace CodeEvalPractice.Easy
{
    // https://www.codeeval.com/open_challenges/18/
    class MultiplesOfANumber
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

                int compVal = System.Int32.Parse(paramVals[0]);
                int baseVal = System.Int32.Parse(paramVals[1]);
                int currVal = baseVal;
                
                while (currVal <= compVal)
                {
                    currVal += baseVal;
                }

                System.Console.WriteLine(currVal);
            }
        }
    }
}
