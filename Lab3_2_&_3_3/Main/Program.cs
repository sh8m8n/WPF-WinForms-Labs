using RAMDataBase;
using Interactors;
using ConsoleView.Controllers;
using ConsoleView.View;
using ConsoleView.Presenters;
using WinFormsView;
using System.Windows.Forms;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WinFormRamDemo();
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
            RepositoryFactory repositoryFactory = new RepositoryFactory();

            //Презентаторы
            StudentManagementPresenter studentManagementPresenter = new StudentManagementPresenter();
            ErrorPresenter errorPresenter = new ErrorPresenter();

            //Представления
            ErrorWindowView errorWindow = new ErrorWindowView();
            MainWindowView mainWindow = new MainWindowView();

            //=======================ЗАВИСИМОСТИ======================

            //Контроллеры
            studentManagementController.studentManager = studentManagementUseCase;
            studentManagementController.errorNotificator = errorNotificationUseCase;

            //Интеракторы
            studentManagementUseCase.presenter = studentManagementPresenter;
            studentManagementUseCase.repositoryFactory = repositoryFactory;
            errorNotificationUseCase.presenter = errorPresenter;

            //Презентаторы
            studentManagementPresenter.MainWindow = mainWindow;
            errorPresenter.errorWindow = errorWindow;

            studentManagementController.Main();
        }

        private static void WinFormRamDemo()
        {
            //инетракторы
            StudentManagementUseCase studentManagementUseCase = new StudentManagementUseCase();

            //БД
            RAMStudentRepository rAMStudentRepository = new RAMStudentRepository();
            RepositoryFactory repositoryFactory = new RepositoryFactory();

            //Презентаторы
            var studentManagementPresenter = new WinFormsView.Presenter.StudentManagementPresenter();

            //Представления
            var MainWindow = new WinFormsView.View.MainWindow();

            //=======================ЗАВИСИМОСТИ======================

            //Интеракторы
            studentManagementUseCase.presenter = studentManagementPresenter;
            studentManagementUseCase.repositoryFactory = repositoryFactory;

            //Презентаторы
            studentManagementPresenter.studentManager = studentManagementUseCase;
            studentManagementPresenter.view = MainWindow;

            //Представления
            MainWindow.studentManagementController = studentManagementPresenter;

            MainWindow.ShowDialog();
        }
    }
}
