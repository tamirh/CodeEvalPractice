namespace CodeEvalPractice.Easy
{
    class UniqueElements
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

                string[] elements = line.Split(',');
                int[] intElements = System.Array.ConvertAll(elements, System.Int32.Parse);

                System.Collections.Generic.HashSet<int> set = new System.Collections.Generic.HashSet<int>();

                foreach (int element in intElements)
                {
                    if (!set.Contains(element))
                        set.Add(element);
                }

                int[] uniqueElements = new int[set.Count];
                set.CopyTo(uniqueElements);

                System.Array.Sort(uniqueElements);

                System.Console.WriteLine(string.Join(",", uniqueElements));
            }
        }

        /*
        public static void Main(string[] args)
        {
            System.IO.StreamReader reader = OpenInput(args);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null)
                    continue;
                
                string[] elements = line.Split(',');
                int[] intElements = System.Array.ConvertAll(elements, System.Int32.Parse);

                int begin = 0;
                int end = 0;
                while (end < intElements.Length)
                {
                    // Get current value, and then iterate until we find a non-duplicate
                    int curr = intElements[begin];
                    int next = curr;
                    end = begin + 1;
                    while (next == curr && end < intElements.Length)
                    {
                        next = intElements[end++];
                    }

                    // Advance our current pointer
                    begin = end - 1;

                    if (end >= intElements.Length)
                    {
                        // Last value, no comma
                        System.Console.Write(curr);
                    }
                    else
                    {
                        // Will be more values, comma
                        System.Console.Write("{0},", curr);
                    }
                }

                System.Console.WriteLine();
            }
        }*/
    }
}