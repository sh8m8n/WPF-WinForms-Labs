using Entities;

namespace BusinessLogic.Interfaces
{
    public interface IRepositoryFactory<Entity> where Entity : IEntity
    {
        IRepository<Entity> CreateInstance();
    }
}
