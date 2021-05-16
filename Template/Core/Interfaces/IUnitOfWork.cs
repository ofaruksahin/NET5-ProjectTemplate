using System;

namespace $safeprojectname$.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
        bool Rollback();
    }
}
