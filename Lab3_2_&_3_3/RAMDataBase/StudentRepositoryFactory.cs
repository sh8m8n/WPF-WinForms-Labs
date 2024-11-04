using BusinessLogic.Interfaces;
using Entities;

namespace RAMDataBase
{
    public class StudentRepositoryFactory : IRepositoryFactory<Student>
    {
        public IRepository<Student> CreateInstance()
        {
            return new RAMStudentRepository();
        }
    }
}
