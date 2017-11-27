namespace BugManagement.Infrastructure
{
    public interface IUnitOfWork
    {
        #region Property

        bool IsCommitted { get; }

        #endregion

        #region Method

        /// <summary>
        /// Submit current unit operation
        /// </summary>
        /// <returns></returns>
        int Commit();

        /// <summary>
        /// Rollback current unit to the status of uncommitted
        /// Set property IsCommited to false
        /// </summary>
        void Rollback();

        #endregion
    }
}
