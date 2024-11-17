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
                    errorNotificator.NotificateError(error);
                }

                string[] args = command.Split(' ');

                if(args.Length <= 1)
                {
                    var error = new ErrorData("Команды не существует",
                                "обратите внимание на список комманд");
                    errorNotificator.NotificateError(error);
                    Console.ReadKey();
                    continue;
                }

                switch (args[0])
                {
                    case "1":
                        if (args.Length != 4)
                        {
                            var error = new ErrorData("Неверное число атрибутов",
                                "Необходимые атриубуты: номер команды, имя, группа, специальность");
                            errorNotificator.NotificateError(error);
                            Console.ReadKey();
                        }
                        else
                        {
                            var StudentPersonalData = new StudentPersonalData()
                            {
                                Name = args[1],
                                Speciality = args[2],
                                Group = args[3],
                            };
                        }
                        break;

                    case "2":
                        if (args.Length != 2)
                        {
                            var error = new ErrorData("Неверное число атрибутов",
                                "Необходимые атриубуты: номер команды, айдиСтудента");
                            errorNotificator.NotificateError(error);
                            Console.ReadKey();
                        }
                        else if (!int.TryParse(args[1], out int c))
                        {
                            var error = new ErrorData("Неверный атрибут",
                                "ID студента представлен числом");
                            errorNotificator.NotificateError(error);
                            Console.ReadKey();
                        }
                        else
                        {
                            int id = int.Parse(args[1]);
                            studentManager.DeleteStudent(id);
                        }
                        break;

                    case "3":
                        if (args.Length != 5)
                        {
                            var error = new ErrorData("Неверное число атрибутов",
                                "Необходимые атриубуты: номер команды, ID, имя, группа, специальность");
                            errorNotificator.NotificateError(error);
                            Console.ReadKey();
                        }
                        else if (!int.TryParse(args[1], out int c))
                        {
                            var error = new ErrorData("Неверный атрибут",
                                "ID студента представлен числом");
                            errorNotificator.NotificateError(error);
                            Console.ReadKey();
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
                        errorNotificator.NotificateError(error2);
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
