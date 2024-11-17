using Interactors;
using Interactors.DTOs;
using Interactors.Interfaces;
using System;

namespace ConsoleView.Controllers
{
    public class StudentManagementController
    {
        public IStudentsManagementInputPort studentManager;
        public IErrorNotificationInputPort errorNotificator;

        public void Main()
        {

            studentManager.ReadAllStudents();

            while (true)
            {
                string command = Console.ReadLine();

                if(string.IsNullOrEmpty(command))
                {
                    var error = new ErrorData("Строка Пустая", "заполните ее");
                    InvokeErrorDialog(error);
                }

                string[] args = command.Split(' ');

                if(args.Length <= 1)
                {
                    var error = new ErrorData("Команды не существует", "обратите внимание на список команд");
                    InvokeErrorDialog(error);
                    continue;
                }

                switch (args[0])
                {
                    case "a":
                    case "add":
                        if (args.Length != 4)
                        {
                            var error = new ErrorData("Неверное число атрибутов",
                                "Необходимые атриубуты: команда, имя, группа, специальность");
                            InvokeErrorDialog(error);
                        }
                        else
                        {
                            var StudentPersonalData = new StudentPersonalData()
                            {
                                Name = args[1],
                                Speciality = args[2],
                                Group = args[3],
                            };
                            
                            studentManager.CreateStudent(StudentPersonalData);
                        }
                        break;

                    case "d":
                    case "delete":
                        if (args.Length != 2)
                        {
                            var error = new ErrorData("Неверное число атрибутов",
                                "Необходимые атриубуты команда, айдиСтудента");
                            InvokeErrorDialog(error);
                        }
                        else if (!int.TryParse(args[1], out int c))
                        {
                            var error = new ErrorData("Неверный атрибут",
                                "ID студента должен быть представлен числом");
                            InvokeErrorDialog(error);
                        }
                        else
                        {
                            int id = int.Parse(args[1]);
                            studentManager.DeleteStudent(id);
                        }
                        break;

                    case "u":
                    case "update":
                        if (args.Length != 5)
                        {
                            var error = new ErrorData("Неверное число атрибутов",
                                "Необходимые атриубуты: команда, ID, имя, группа, специальность");
                            InvokeErrorDialog(error);
                        }
                        else if (!int.TryParse(args[1], out int c))
                        {
                            var error = new ErrorData("Неверный атрибут",
                                "ID студента должен быть представлен числом");
                            InvokeErrorDialog(error);
                        }
                        else
                        {
                            int id = int.Parse(args[1]);
                            studentManager.DeleteStudent(id);

                            var StudentPersonalData = new StudentPersonalData()
                            {
                                Name = args[2],
                                Speciality = args[3],
                                Group = args[4],
                            };

                            studentManager.UpdateStudent(id, StudentPersonalData);
                        }
                        break;

                    default:
                        var error2 = new ErrorData("Команды не существует",
                                "обратите внимание на список комманд");
                        InvokeErrorDialog(error2);
                        break;

                }

            }
        }

        private void InvokeErrorDialog(ErrorData errorData)
        {
            errorNotificator.NotificateError(errorData);
            Console.ReadKey();
            studentManager.ReadAllStudents();
        }
    }
}
