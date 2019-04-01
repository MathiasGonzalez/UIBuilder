using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibGit2Sharp;
namespace GitManager
{
    public class GitManager : IDisposable
    {
        Repository _repository;


        Repository repository
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


        public string InitRepo(string path, bool isBare = false)
        {

            var result = Repository.Init(path, isBare);

            return result;
        }

        public void Dispose()
        {
            repository.Dispose();
        }
    }
}
