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
            // key=team
            // value=list of countries that support this team
            System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.SortedSet<int>> teamSupporters = new System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.SortedSet<int>>();

            string[] teamsSupportedByCountries = input.Split(new char[] { '|' }, System.StringSplitOptions.RemoveEmptyEntries);

            int countryId = 0;
            foreach( string teamsSupportedByThisCountryString in teamsSupportedByCountries)
            {
                countryId++;

                string[] teamsSupportedByThisCountry = teamsSupportedByThisCountryString.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
                foreach( string teamSupportedByThisCountry in teamsSupportedByThisCountry)
                {
                    int teamId = System.Int32.Parse(teamSupportedByThisCountry);
                    if (!teamSupporters.ContainsKey(teamId))
                    {
                        teamSupporters.Add(teamId, new System.Collections.Generic.SortedSet<int>());
                    }

                    teamSupporters[teamId].Add(countryId);
                }
            }

            System.Collections.Generic.List<string> output = new System.Collections.Generic.List<string>();
            foreach( int teamId in teamSupporters.Keys )
            {
                System.Collections.Generic.SortedSet<int> countriesThatSupportTeam = teamSupporters[teamId];
                int[] countryList = new int[countriesThatSupportTeam.Count];
                countriesThatSupportTeam.CopyTo(countryList);

                output.Add(teamId + ":" + string.Join(",", countryList) + ";");
            }

            System.Console.WriteLine(string.Join(" ", output.ToArray()));
        }
    }
}
