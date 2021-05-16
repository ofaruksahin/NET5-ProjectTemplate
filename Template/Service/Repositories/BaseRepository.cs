using Core.Interfaces;
using System.Data;

namespace $safeprojectname$.Repositories
{
    public class BaseRepository
    {
        private IDbTransaction _transaction { get; set; }

        private IDbContext _instance { get; set; }


        protected IDbContext connection
        {
            get
            {
                return _instance ?? (_instance = new DbContext(_transaction));
            }
        }

        public BaseRepository(IDbTransaction transaction)
        {
            this._transaction = transaction;
        }
    }
}
