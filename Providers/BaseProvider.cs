using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1.Providers
{
    public class BaseProvider : IDisposable
    {
        private readonly PostDataEntities _context;

        public BaseProvider()
        {
            _context = new PostDataEntities();
        }

        public PostDataEntities Context { get { return _context; } }
        #region IDisposable 
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}