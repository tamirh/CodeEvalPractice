namespace CodeEvalPractice.Moderate
{
    class LongestLines
    {
        static System.IO.StreamReader OpenInput(string[] args)
        {
            string filename;
            if (args == null || args.Length < 1)
            {
                filename = "./../../Moderate/" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name + ".txt";
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
            int numLines = System.Int32.Parse(reader.ReadLine());

            System.Collections.Generic.SortedList<int, string> longest = new System.Collections.Generic.SortedList<int, string>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                    continue;

                if (longest.Count < numLines)
                {
                    longest.Add(line.Length, line);
                }
                else if (line.Length > longest.Keys[0])
                {
                    // We need to add this line and push out the extra that's smallest in our list
                    longest.Add(line.Length, line);
                    longest.RemoveAt(0);
                }
            }

            System.Collections.Generic.IList<int> keys = longest.Keys;
            for (int i = keys.Count - 1; i >= 0; --i)
            {
                System.Console.WriteLine(longest[keys[i]]);
            }
        }
    }
}
