namespace CodeEvalPractice.Easy
{
    class SetIntersection
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

                string[] lists = line.Split(';');
                int[] list1 = System.Array.ConvertAll(lists[0].Split(','), System.Int32.Parse);
                int[] list2 = System.Array.ConvertAll(lists[1].Split(','), System.Int32.Parse);

                int i1 = 0;
                int i2 = 0;
                System.Collections.Generic.List<int> intersection = new System.Collections.Generic.List<int>();
                while(i1 < list1.Length && i2 < list2.Length)
                {
                    int val1 = list1[i1];
                    int val2 = list2[i2];

                    if (val1 == val2)
                    {
                        intersection.Add(val1);
                        i1++;
                        i2++;
                    } else if (val1 > val2)
                    {
                        // list2 needs to catch up
                        i2++;
                    } else // val1 < val2
                    {
                        // list1 needs to catch up
                        i1++;
                    }
                }

                System.Console.WriteLine(string.Join(",", intersection.ToArray()));
            }
        }
    }
}
