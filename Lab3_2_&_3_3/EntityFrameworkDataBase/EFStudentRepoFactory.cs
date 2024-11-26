using Interactors.Interfaces;
using Entities;

namespace EntityFrameworkDB
{
    public class EFStudentRepoFactory : IRepositoryFactory<IRepository<Student>>
    {
        static IRepository<Student> repository;

        public IRepository<Student> Create()
        {
            if(repository == null)
            {
                repository = new EFStudentRepository(new ApplicationDbContext());
            }
            return repository;
        }
    }
}
