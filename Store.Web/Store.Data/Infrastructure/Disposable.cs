using System;

namespace Store.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        /// <summary>
        /// Override this to dispose custom objects
        /// This virtual method makes other classess to inherit this one, 
        /// to dispose their own objects in the way they need to.
        /// </summary>
        protected virtual void DisposeCore()
        {
        }
    }
}
