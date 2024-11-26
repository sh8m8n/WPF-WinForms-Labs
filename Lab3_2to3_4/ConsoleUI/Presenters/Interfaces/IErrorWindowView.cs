using ConsoleUI.ViewModels;

namespace ConsoleUI.Presenters.Interfaces
{
    public interface IErrorWindowView
    {
        void Render(ErrorWindowViewModel viewModel);
    }
}
