using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibGit2Sharp;
namespace GitManager
{
    public class GitManager : IDisposable
    {
        Repository _repository;


        public Repository repository
        {
            get { return _repository; }
        }

        public GitManager()
        {

        }

        public GitManager(string repoPath)
        {

            _repository = new Repository(repoPath);
        }


        public static string InitRepo(string path, bool isBare = false)
        {
            if (Directory.Exists(path))
            {

                var result = Repository.Init(path, isBare);

                return result;
            }
            else
            {
                throw new Exception("path : " + path + " : No existe");
            }
        }

        public List<string> Untracked()
        {

            var status = this.repository.RetrieveStatus();

            if (status.IsDirty) {
                var untracked = status.Untracked.ToList();
                return untracked.Select(x => x.FilePath +" State : "+ x.State.ToString() ).ToList();
            }
            else
                return new List<string>();

        }

        public void Stage(string path)
        {
            Commands.Stage(this.repository, path);
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
