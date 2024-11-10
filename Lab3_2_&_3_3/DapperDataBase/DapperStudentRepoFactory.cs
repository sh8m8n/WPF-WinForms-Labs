using BusinessLogic;
using BusinessLogic.Interfaces;
using Entities;
using System;

namespace DapperDataBase
{
    public class DapperStudentRepoFactory : IRepositoryFactory<Student>
    {

        DapperStudentRepository repository = new DapperStudentRepository();


        public IRepository<Student> CreateInstance()
        {
            return repository;
        }
    }
}
