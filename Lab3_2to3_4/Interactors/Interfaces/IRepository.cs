namespace Interactors.Interfaces
{
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Возвращает созданную пустую сущность
        /// </summary>
        /// <returns></returns>
        TEntity Create();

        void Delete(int ID);

        void Update(TEntity entity);

        TEntity Read(int ID);

        IEnumerable<TEntity> ReadAll();
    }
}
