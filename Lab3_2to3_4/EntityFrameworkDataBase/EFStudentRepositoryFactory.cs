using Entities;
using Interactors.Interfaces;

namespace EntityFrameworkDataBase
{
    public class EFStudentRepositoryFactory : IRepositoryFactory<IRepository<Student>>
    {
        static IRepository<Student> repository;

        public IRepository<Student> Create()
        {
            if (repository == null)
            {
                repository = new EFStudentRepository(new ApplicationDbContext());
            }
            return repository;
        }
    }
}
