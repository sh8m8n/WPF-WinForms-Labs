using RAMDataBase;
using Interactors;
using ConsoleUI.Controllers;
using ConsoleUI.View;
using ConsoleUI.Presenters;
using DapperDataBase;
using System.Threading.Tasks;
using EntityFrameworkDataBase;

namespace Main
{
    internal class Program
    {
        static void Main()
        {
            ConsoleEFConfig();
        }

        private static void ConsoleRamConfig()
        {
            //Контроллеры
            MainWindowController studentManagementController = new MainWindowController();

            //инетракторы
            ErrorNotificationUseCase errorNotificationUseCase = new ErrorNotificationUseCase();
            StudentManagementUseCase studentManagementUseCase = new StudentManagementUseCase();

            //БД
            RAMStudentRepositoryFactory repositoryFactory = new RAMStudentRepositoryFactory();

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

        private static void WinFormRamConfig()
        {
        //    //инетракторы
        //    StudentManagementUseCase studentManagementUseCase = new StudentManagementUseCase();

        //    //БД
        //    RAMStudentRepository rAMStudentRepository = new RAMStudentRepository();
        //    RepositoryFactory repositoryFactory = new RepositoryFactory();

        //    //Презентаторы
        //    var studentManagementPresenter = new WinFormsView.Presenter.StudentManagementPresenter();

        //    //Представления
        //    var MainWindow = new WinFormsView.View.MainWindow();

        //    //=======================ЗАВИСИМОСТИ======================

        //    //Интеракторы
        //    studentManagementUseCase.presenter = studentManagementPresenter;
        //    studentManagementUseCase.repositoryFactory = repositoryFactory;

        //    //Презентаторы
        //    studentManagementPresenter.studentManager = studentManagementUseCase;
        //    studentManagementPresenter.view = MainWindow;

        //    //Представления
        //    MainWindow.studentManagementController = studentManagementPresenter;

        //    MainWindow.ShowDialog();
        }

        private static void ConsoleDapperConfig()
        {
            //Контроллеры
            MainWindowController studentManagementController = new MainWindowController();

            //инетракторы
            ErrorNotificationUseCase errorNotificationUseCase = new ErrorNotificationUseCase();
            StudentManagementUseCase studentManagementUseCase = new StudentManagementUseCase();

            //БД
            DapperStudentRepositoryFactory dapperDBFactory = new DapperStudentRepositoryFactory();


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
            studentManagementUseCase.repositoryFactory = dapperDBFactory;
            errorNotificationUseCase.presenter = errorPresenter;

            //Презентаторы
            studentManagementPresenter.MainWindow = mainWindow;
            errorPresenter.errorWindow = errorWindow;

            studentManagementController.Main();
        }

        private static void ConsoleEFConfig()
        {
            //Контроллеры
            MainWindowController studentManagementController = new MainWindowController();

            //инетракторы
            ErrorNotificationUseCase errorNotificationUseCase = new ErrorNotificationUseCase();
            StudentManagementUseCase studentManagementUseCase = new StudentManagementUseCase();

            //БД
            EFStudentRepositoryFactory eFStudentRepositoryFactory = new EFStudentRepositoryFactory();

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
            studentManagementUseCase.repositoryFactory = eFStudentRepositoryFactory;
            errorNotificationUseCase.presenter = errorPresenter;

            //Презентаторы
            studentManagementPresenter.MainWindow = mainWindow;
            errorPresenter.errorWindow = errorWindow;

            studentManagementController.Main();
        }
    }
}