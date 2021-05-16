using System;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
        bool Rollback();
    }
}
