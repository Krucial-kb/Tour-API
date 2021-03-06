﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tour.Domain.DomainModels;
using Tour.Domain.Interfaces;

namespace Tour.DataAccess.Repository
{
    public class PostsRepository : IPostsRepository
    {
        public EntityState Changed(Users user)
        {
            throw new NotImplementedException();
        }

        public Task<Posts> CreatePostAsync(Posts post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePostAsync(int postID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Posts>> GetPostsAsync(Posts post)
        {
            throw new NotImplementedException();
        }

        public Task<Posts> GetPostsByIdAsync(int postID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostExistsAsync(int postID)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdatePostAsync(Posts post)
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
        // ~PostsRepository()
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
