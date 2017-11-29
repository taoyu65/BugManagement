using BugManagement.Infrastructure.Tools;
using BugManagement.Infrastructure.Tools.Exceptions;
using BugManagement.Infrastructure.Tools.Helpers;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BugManagement.Infrastructure
{
    public abstract class EFRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        #region Property

        [Import]
        public IUnitOfWork UnitOfWork { get; set; }

        protected IUnitOfWorkContext EFContext
        {
            get
            {
                if (UnitOfWork is IUnitOfWorkContext)
                {
                    return UnitOfWork as IUnitOfWorkContext;
                }
                throw new DataAccessException(string.Format("Repository context type is invalid, should be IRepositoryContext, now is {0}", UnitOfWork.GetType().Name));
            }
        }

        public virtual IQueryable<TEntity> Entities
        {
            get
            {
                return EFContext.Set<TEntity>();
            }
        }

        #endregion

        #region Public Method

        public virtual int Insert(TEntity entity, bool isSave = true)
        {
            PublicHelper.CheckArgument(entity, "entity");
            EFContext.RegisterNew(entity);
            return isSave ? EFContext.Commit() : 0;
        }

        public virtual int Insert(IEnumerable<TEntity> entities, bool isSave = true)
        {
            PublicHelper.CheckArgument(entities, "entities");
            EFContext.RegisterNew(entities);
            return isSave ? EFContext.Commit() : 0;
        }

        public virtual int Delete(object id, bool isSave = true)
        {
            PublicHelper.CheckArgument(id, "id");
            TEntity entity = EFContext.Set<TEntity>().Find(id);
            return entity != null ? Delete(entity, isSave) : 0;
        }

        public virtual int Delete(TEntity entity, bool isSave = true)
        {
            PublicHelper.CheckArgument(entity, "entity");
            EFContext.RegisterDeleted(entity);
            return isSave ? EFContext.Commit() : 0;
        }

        public virtual int Delete(IEnumerable<TEntity> entities, bool isSave = true)
        {
            PublicHelper.CheckArgument(entities, "entities");
            EFContext.RegisterDeleted(entities);
            return isSave ? EFContext.Commit() : 0;
        }

        public virtual int Delete(Expression<Func<TEntity, bool>> predicate, bool isSave = true)
        {
            PublicHelper.CheckArgument(predicate, "predicate");
            List<TEntity> entities = EFContext.Set<TEntity>().Where(predicate).ToList();
            return entities.Count > 0 ? Delete(entities, isSave) : 0;
        }

        public virtual int Update(TEntity entity, bool isSave = true)
        {
            PublicHelper.CheckArgument(entity, "entity");
            EFContext.RegisterModified(entity);
            return isSave ? EFContext.Commit() : 0;
        }

        public virtual TEntity GetByKey(object key)
        {
            PublicHelper.CheckArgument(key, "key");
            return EFContext.Set<TEntity>().Find(key);
        }
        #endregion
    }
}
