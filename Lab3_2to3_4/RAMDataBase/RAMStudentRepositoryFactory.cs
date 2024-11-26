using Entities;
using Interactors.Interfaces;

namespace RAMDataBase
{
    public class RAMStudentRepositoryFactory : IRepositoryFactory<IRepository<Student>>
    {
        private static RAMStudentRepository repo;

        public IRepository<Student> Create()
        {
            if (repo == null)
                repo = new RAMStudentRepository();

            return repo;
        }
    }
}
