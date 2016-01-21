namespace CodeEvalPractice.Easy
{
    class MultiplyLists
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

                string[] lists = line.Split('|');
                string[] leftListStrings = lists[0].Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                string[] rightListStrings = lists[1].Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

                int[] leftList = System.Array.ConvertAll(leftListStrings, System.Int32.Parse);
                int[] rightList = System.Array.ConvertAll(rightListStrings, System.Int32.Parse);

                int[] result = new int[leftList.Length];
                for (int i=0; i<leftList.Length; ++i)
                {
                    result[i] = leftList[i] * rightList[i];
                }

                System.Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
