namespace Interactors.Interfaces
{
    public interface IRepositoryFactory<TEntity>
    {
        TEntity Create();
    }
}
