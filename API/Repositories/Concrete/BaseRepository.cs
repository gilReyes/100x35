using Entity;
using System;

namespace API.Repositories
{
    public class BaseRepository : IDisposable
    {
        private bool disposed = false;
        public DataModelConnection context;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}