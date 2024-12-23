namespace SiteFileParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "POS_SITE2.CSV";
            string outputFile = "SITE_OUT2.CSV";

            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');

                    if (columns.Length >= 15)
                    {
                        string secondColumn = columns[1].Trim('"');

                        if (secondColumn == "IM" || secondColumn == "IU" || secondColumn == "WK" || secondColumn == "XE")
                        {
                            writer.WriteLine(string.Join(",", columns[..15]));
                        }
                    }
                }
            }
        }
    }
}
