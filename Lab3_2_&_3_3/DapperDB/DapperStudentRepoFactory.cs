using Interactors.Interfaces;
using Entities;

namespace DapperDB
{
    public class DapperStudentRepoFactory : IRepositoryFactory<IRepository<Student>>
    {
        private static StudentRepository repo;
        public IRepository<Student> Create()
        {
            if(repo == null)
            {
                repo = new StudentRepository();
            }

            return repo;
        }
    }
}
