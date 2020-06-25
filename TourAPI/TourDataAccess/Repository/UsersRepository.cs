using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tour.Domain.Interfaces;

namespace Tour.DataAccess.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public async Task<Domain.DomainModels.Users> CreateUserAsync(Domain.DomainModels.Users user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserAsync(int userID)
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.DomainModels.Users> GetPatientByUsernameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public async Task<Domain.DomainModels.Users> GetUserByIdAsync(int userID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Domain.DomainModels.Users>> GetUsersAsync(string search = null)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUserAsync(Domain.DomainModels.Users user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UserExistsAsync(int userid)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UsersRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
