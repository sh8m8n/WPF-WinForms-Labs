using RAMDataBase;
using Interactors;
using ConsoleView.Controllers;
using ConsoleView.View;
using ConsoleView.Presenters;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleRamDemo();
        }

        private static void ConsoleRamDemo()
        {
            //Контроллеры
            StudentManagementController studentManagementController = new StudentManagementController();

            //инетракторы
            ErrorNotificationUseCase errorNotificationUseCase = new ErrorNotificationUseCase();
            StudentManagementUseCase studentManagementUseCase = new StudentManagementUseCase();

            //БД
            RAMStudentRepository rAMStudentRepository = new RAMStudentRepository();

            //Презентаторы
            StudentManagementPresenter studentManagementPresenter = new StudentManagementPresenter();
            ErrorPresenter errorPresenter = new ErrorPresenter();

            //Представления
            ErrorWindow errorWindow = new ErrorWindow();
            MainWindowView mainWindow = new MainWindowView();

            //=======================ЗАВИСИМОСТИ======================

            //Контроллеры
            studentManagementController.studentManager = studentManagementUseCase;
            studentManagementController.errorNotificator = errorNotificationUseCase;

            //Интеракторы
            studentManagementUseCase.presenter = studentManagementPresenter;
            studentManagementUseCase.studentRepository = rAMStudentRepository;
            errorNotificationUseCase.presenter = errorPresenter;

            //Презентаторы
            studentManagementPresenter.MainWindow = mainWindow;
            errorPresenter.errorWindow = errorWindow;

            studentManagementController.Main();
        }
    }
}
