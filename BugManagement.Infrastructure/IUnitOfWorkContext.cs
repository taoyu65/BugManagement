using BugManagement.Infrastructure.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BugManagement.Infrastructure
{
    public interface IUnitOfWorkContext: IUnitOfWork, IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : Entity;

        void RegisterNew<TEntity>(TEntity entity) where TEntity : Entity;

        void RegisterNew<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity;

        void RegisterModified<TEntity>(TEntity entity) where TEntity : Entity;

        void RegisterDeleted<TEntity>(TEntity entity) where TEntity : Entity;

        void RegisterDeleted<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity;
    }
}
