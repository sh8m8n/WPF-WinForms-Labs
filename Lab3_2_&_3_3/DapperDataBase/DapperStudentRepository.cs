using BusinessLogic.Interfaces;
using Dapper;
using Entities;
using System.Collections.Generic;
using Npgsql;
using System.Data;
using System.Linq;

namespace DapperDataBase
{
    public class DapperStudentRepository : IRepository<Student>
    {
        private readonly string _connectionString
            = "Host=localhost;Port=5432;Database=DapperStudentDB;Username=postgres;Password=2064243;";


        public Student Create()
        {
            // Метод Create не принимает параметров, поэтому создадим нового студента с пустыми значениями
            var newStudent = new Student(0) // ID будет назначен в БД
            {
                Name = string.Empty,
                Speciality = string.Empty,
                Group = string.Empty
            };

            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sql = "INSERT INTO Students (Name, Speciality, StudentGroup) VALUES (@Name, @Speciality, @Group) RETURNING ID;";
                newStudent.ID = db.ExecuteScalar<int>(sql, newStudent);
            }

            return newStudent;
        }

        public Student Read(int id)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Students WHERE ID = @Id;";
                return db.QuerySingleOrDefault<Student>(sql, new { Id = id });
            }
        }

        public IEnumerable<Student> ReadAll()
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Students;";
                return db.Query<Student>(sql).ToList();
            }
        }

        public void Update(Student student)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sql = "UPDATE Students SET Name = @Name, Speciality = @Speciality, StudentGroup = @Group WHERE ID = @Id;";
                db.Execute(sql, student);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sql = "DELETE FROM Students WHERE ID = @Id;";
                db.Execute(sql, new { Id = id });
            }
        }
    }
}
