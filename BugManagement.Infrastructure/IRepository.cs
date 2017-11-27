using BugManagement.Infrastructure.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BugManagement.Infrastructure
{
    public interface IRepository<TEntity> where TEntity: Entity
    {
        #region Property

        IQueryable<TEntity> Entities { get; }

        #endregion

        #region Public Interface Method

        int Insert(TEntity entity, bool isSave = true);

        int Insert(IEnumerable<Entity> entities, bool isSave = true);

        int Delete(object id, bool isSave = true);

        int Delete(TEntity entity, bool isSave = true);

        int Delete(IEnumerable<TEntity> entities, bool isSave = true);

        /// <summary>
        /// Delete all records which matches lambda expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        int Delete(Expression<Func<TEntity, bool>> predicate, bool isSave = true);

        int Update(TEntity entity, bool isSave = true);
        
        /// <summary>
        /// Get object according to the key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        TEntity GetByKey(object key);

        #endregion

    }
}
