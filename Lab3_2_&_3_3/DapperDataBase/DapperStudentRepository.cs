using BusinessLogic.Interfaces;
using Dapper;
using Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DapperDataBase
{
    internal class DapperStudentRepository : IRepository<Student>
    {
        private readonly string _connectionString;

        public DapperStudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Student Create()
        {
            // Здесь можно создать новый объект Student и сохранить его в БД
            var student = new Student(0) // ID будет присвоен при вставке

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO Students (Name, Speciality, Group) VALUES(@Name, @Speciality, @Group); SELECT CAST(SCOPE_IDENTITY() as int);";
                student.ID = db.QuerySingle<int>(sqlQuery, student);
            }

            return student;
        }

        public Student Read(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "SELECT * FROM Students WHERE ID = @Id;";
                return db.QuerySingleOrDefault<Student>(sqlQuery, new { Id = id });
            }
        }

        public IEnumerable<Student> ReadAll()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "SELECT * FROM Students;";
                return db.Query<Student>(sqlQuery);
            }
        }

        public void Update(Student entity)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "UPDATE Students SET Name = @Name, Speciality = @Speciality, Group = @Group WHERE ID = @Id;";
                db.Execute(sqlQuery, new { entity.Name, entity.Speciality, entity.Group, Id = entity.ID });
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "DELETE FROM Students WHERE ID = @Id;";
                db.Execute(sqlQuery, new { Id = id });
            }
        }
    }
}
