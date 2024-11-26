namespace Interactors.Interfaces
{
    public interface IRepositoryFactory<TRepository>
    {
        TRepository Create();
    }
}
