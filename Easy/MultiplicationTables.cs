namespace CodeEvalPractice.Easy
{
    class MultiplicationTables
    {
        public static void Main(string[] args)
        {
            const int DEFAULT_NROWS = 12;
            const int DEFAULT_NCOLS = 12;
            int nRows = DEFAULT_NROWS;
            int nCols = DEFAULT_NCOLS;

            System.Text.StringBuilder output = new System.Text.StringBuilder();
            for (int col = 1; col <= nCols; ++col)
            {
                for (int row = 1; row <= nRows; ++row)
                {
                    output.Append(System.String.Format("{0,4}", row * col));
                }

                output.AppendLine();
            }

            System.Console.Write(output.ToString());
        }
    }
}
