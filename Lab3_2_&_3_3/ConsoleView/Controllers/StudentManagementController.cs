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

                switch (args[0])
                {
                    case "1":
                        if (args.Length != 4)
                        {
                            var error = new ErrorData("Неверное число атрибутов",
                                "Необходимые атриубуты: номер команды, имя, группа, специальность");
                            errorNotificator.NotificateError(error);
                        }
                        else
                        {
                            string 
                        }
                        break;
                }

            }
        }
    }
}
