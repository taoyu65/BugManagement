using System;
using System.Collections.Generic;
using System.Text;
using BugManagement.Infrastructure.Tools;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace BugManagement.Infrastructure
{
    public abstract class UnitOfWorkContextBase : IUnitOfWorkContext
    {
        protected abstract DbContext Context { get; }

        public bool IsCommitted { get; private set; }

        public int Commit()
        {
            if (IsCommitted)
            {
                return 0;
            }
            try
            {
                int num = Context.SaveChanges();
                IsCommitted = true;
                return num;
            }
            catch (DbUpdateException e)
            {
                if (e.InnerException != null && e.InnerException.InnerException is SqlException)
                {
                    SqlException sqlEx = e.InnerException.InnerException as SqlException;
                    string msg = SqlExceptionMessage.GetSqlExceptionMessage(sqlEx.Number);
                    throw PublicHelper.ThrowDataAccessException("Exception occur when updated: " + msg, sqlEx);
                }
                throw;
            }
        }

        public void Dispose()
        {
            if (!IsCommitted)
            {
                Commit();
            }
            Context.Dispose();
        }

        public void RegisterDeleted<TEntity>(TEntity entity) where TEntity : Entity
        {
            Context.Entry(entity).State = EntityState.Deleted;
            IsCommitted = false;
        }

        public void RegisterDeleted<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            try
            {
                foreach(TEntity entity in entities)
                {
                    RegisterDeleted(entity);
                }
            }
            finally
            { }
        }

        public void RegisterModified<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                Context.Set<TEntity>().Attach(entity);
            }
            Context.Entry(entity).State = EntityState.Modified;
            IsCommitted = false;
        }

        public void RegisterNew<TEntity>(TEntity entity) where TEntity : Entity
        {
            EntityState state = Context.Entry(entity).State;
            if (state == EntityState.Detached)
            {
                Context.Entry(entity).State = EntityState.Added;
            }
            IsCommitted = false;
        }

        public void RegisterNew<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            try
            {
                foreach (TEntity entity in entities)
                {
                    RegisterNew(entity);
                }
            }
            finally
            {
                //EF has this property, but not the EFCore
                //Context.Configuration.AutoDetectChangesEnabled = true;
            }
        }

        public void Rollback()
        {
            IsCommitted = false;
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : Entity
        {
            return Context.Set<TEntity>();
        }
    }
}
