namespace CodeEvalPractice.Easy
{
    // https://www.codeeval.com/open_challenges/230/
    class Football
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

                FindTeamAffiliations(line);
            }
        }

        static void FindTeamAffiliations(string input)
        {
            // Each countries' list of teams they like is separated by a |
            // The names of the teams are each separated by a ' '
            string[] teamAffiliationStrings = input.Split(new char[] { '|' }, System.StringSplitOptions.RemoveEmptyEntries);

            // key: teamname
            // value: list of countries that like that team
            System.Collections.Generic.SortedDictionary<string, System.Collections.Generic.List<string>> teamAffiliation = new System.Collections.Generic.SortedDictionary<string, System.Collections.Generic.List<string>>();
            int countryIndex = 0;
            foreach (string teamsLiked in teamAffiliationStrings)
            {
                ++countryIndex;
                string countryName = countryIndex.ToString();

                string[] teams = teamsLiked.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                foreach (string team in teams)
                {
                    if (!teamAffiliation.ContainsKey(team))
                        teamAffiliation.Add(team, new System.Collections.Generic.List<string>());

                    teamAffiliation[team].Add(countryName);
                }
            }
            
            // Go through each team and list out which countries like that team
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            foreach (string team in teamAffiliation.Keys)
            {
                System.Collections.Generic.List<string> countries = teamAffiliation[team];
                countries.Sort();

                output.AppendFormat("{0}:", team);
                output.Append(string.Join(",", countries.ToArray()));
                output.Append("; ");
            }

            // Don't strip off last whitespace?
            System.Console.WriteLine(output.ToString());
        }
    }
}
