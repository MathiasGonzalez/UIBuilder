using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {

            const string repoPath = @"D:\git_test\rep1";

            //Console.WriteLine(repoPath);

            //var repo = GitManager.GitManager.InitRepo(repoPath, false);

            //Console.WriteLine(repo);

            using (var gitManager = new GitManager.GitManager(repoPath))
            {


                const string archivo1PathName = repoPath + @"\archivo1.txt";


                if (File.Exists(archivo1PathName))
                {

                    File.Delete(archivo1PathName);
                }


                File.WriteAllText(archivo1PathName, "texto1");


                Console.WriteLine("----------------------  UNTRACKED FILES --------------");
                
                gitManager.Untracked().ForEach(untrackedFile => { Console.WriteLine(untrackedFile); });
            }

            Console.ReadKey();
        }
    }
}
