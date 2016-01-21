namespace CodeEvalPractice.Easy
{
    class SwapElements
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

                string[] paramVals = line.Split(':');
                string listString = paramVals[0];
                string swapString = paramVals[1];

                string[] list = listString.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                string[] swaps = swapString.Split(new char[] { ' ', ',' }, System.StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string swap in swaps)
                {
                    string[] swapPos = swap.Split('-');
                    int left = System.Int32.Parse(swapPos[0]);
                    int right = System.Int32.Parse(swapPos[1]);

                    string tmp = list[left];
                    list[left] = list[right];
                    list[right] = tmp;
                }

                System.Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
