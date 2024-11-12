using ConsoleView.ViewModels;

namespace ConsoleView.Presenters
{
    public interface IMainWindowView
    {
        void Render(MainWindowViewModel viewModel);
    }
}
