using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFETest
{
    public class pra
    {

        public string path { get; set; }

        public List<string> rawLines { get; set; }


        public pra()
        {
            path = @"C:\SANTANDERPR\Tailored\Databases\Tailored_ICBanking\Scripts\Catalogs\dbo.SiteMapPages.sql";
        }

        public void LoadCatalog()
        {

            var lines = File.ReadAllLines(path);

            rawLines = new List<string>();

            var openComment = false;

            foreach (var line in lines)
            {

                if (line.StartsWith("/*"))
                {
                    openComment = true;  
                }
                if (line.StartsWith("--") || openComment)
                {

                }
                else
                {
                    if (line.StartsWith(","))
                        rawLines.Add(line);
                }
                if (line.StartsWith("*/"))
                {
                    openComment = false;
                }
            }


        }

        //bool isComented(string line)
        //{
        //    bool result = false;

        //    char[] cLine = line.ToCharArray();

        //    for (int i = 0; i < cLine.Length && !result; i++)
        //    {
        //        char c = cLine[i];
        //        if (i == 0 && c.Equals('-'))
        //        {
        //            result = true;
        //        }
        //    }

        //    return result;

        //    //foreach (var ch in line.ToCharArray())
        //    //{

        //    //}
        //}


    }
}
