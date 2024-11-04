using Entities;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="Entity">Хранимая сущность</typeparam>
    public interface IRepository<Entity> where Entity : IEntity
    {
        Entity Create();

        Entity Read(int id);

        IEnumerable<Entity> ReadAll();

        void Update(Entity entity);

        void Delete(int id);
    }
}
