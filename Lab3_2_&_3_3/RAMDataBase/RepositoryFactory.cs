using Interactors.Interfaces;
using Entities;
namespace RAMDataBase
{
    public class RepositoryFactory : IRepositoryFactory<IRepository<Student>>
    {
        private static RAMStudentRepository repo;

        public IRepository<Student> Create()
        {
            if(repo == null)
                repo = new RAMStudentRepository();

            return repo;
        }
    }
}
