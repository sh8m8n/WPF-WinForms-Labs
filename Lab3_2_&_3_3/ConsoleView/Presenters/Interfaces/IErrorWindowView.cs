using ConsoleView.ViewModels;

namespace ConsoleView.Presenters
{
    public interface IErrorWindowView
    {
        void Render(ErrorWindowViewModel viewModel);
    }
}
