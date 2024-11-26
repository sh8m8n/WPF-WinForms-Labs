using DapperDataBase.Entities;
using Entities;
using Interactors.Interfaces;
using System.Data;
using Npgsql;
using Dapper;

namespace DapperDataBase
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly string _connectionString
            = "Host=localhost;Port=5432;Username=postgres;Password=2064243;Database=DapperStudentDB;";

        public Student Create()
        {
            // Метод Create не принимает параметров, поэтому создадим нового студента с пустыми значениями
            var newStudentDB = new StudentDB() // ID будет назначен в БД
            {
                Name = string.Empty,
                Speciality = string.Empty,
                Group = string.Empty
            };

            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sql = "INSERT INTO students (name, speciality, studentgroup) VALUES (@Name, @Speciality, @Group) RETURNING ID;";
                newStudentDB.ID = db.ExecuteScalar<int>(sql, newStudentDB);
            }


            return new Student(newStudentDB.ID, newStudentDB.Name,
                newStudentDB.Speciality, newStudentDB.Group);
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
                var sql = $"UPDATE Students SET name = @Name, speciality = @Speciality, studentgroup = @Group WHERE students.ID = @{student.ID}";
                db.Execute(sql, student);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sql = "DELETE FROM students WHERE ID = @Id;";
                db.Execute(sql, new { Id = id });
            }
        }
    }
}
