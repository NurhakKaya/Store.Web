using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Store.Data.Infrastructure
{
    /// <summary>
    /// Default operations that our repositories will support,
    /// more can be added if wished.
    /// CRUD operations have been commented as Mark to do something,
    /// which means that when a repository implementation adds, updates or removes an entity,
    /// then this does not send the command to the database at that very moment, instead
    /// the caller(service layer) will be responsible to send a Commit command to the database
    /// through IUnitOfWork injected instance. For this to be done, we will use a pattern called
    /// UnitOfWork. See IUnitOfWork and UnitOfWork for more details.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        // Marks an entity as new
        void Add(T entity);

        // Marks an entity as modified
        void Update(T entity);

        // Marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);

        // Get an entity by int id
        T GetById(int id);

        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);

        // Gets all entities of type T
        IEnumerable<T> GetAll();

        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
