using Entities;
using Interactors.Interfaces;

namespace DapperDataBase
{
    public class DapperStudentRepositoryFactory : IRepositoryFactory<IRepository<Student>>
    {
        private static StudentRepository repo;
        public IRepository<Student> Create()
        {
            if (repo == null)
            {
                repo = new StudentRepository();
            }

            return repo;
        }
    }
}
