using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Domain.DomainModels;
using Tour.Domain.Interfaces;


namespace Tour.DataAccess.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly TourAPI.Models.TourContext _ctx;

        public UsersRepository(TourAPI.Models.TourContext context)
        {
            _ctx = context;
        }
        
        public EntityState Changed(Users user)
        {
            throw new NotImplementedException();
        }

        public async Task<Users> CreateUserAsync(Domain.DomainModels.Users user)
        {
            var newUser = new TourAPI.Models.Users
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                ProfilePic = user.ProfilePic,
                Posts = user.Posts
            };

            _ctx.Users.Add(newUser);
            await _ctx.SaveChangesAsync();
            return Mapper.Mapper.MapUsers(newUser);
        }

        public async Task DeleteUserAsync(int userID)
        {
            _ctx.Remove(userID);
            await _ctx.SaveChangesAsync();


        }

        public async Task<Users> GetPatientByUsernameAsync(string userName)
        {
            TourAPI.Models.Users user = await _ctx.Users.FirstAsync(u => u.UserName == userName);

            return Mapper.Mapper.MapUsers(user);
        }

        public async Task<Users> GetUserByIdAsync(int userID)
        {
            TourAPI.Models.Users user = await _ctx.Users.FirstAsync(u => u.UserId == userID);

            return Mapper.Mapper.MapUsers(user);
        }

        public async Task<IEnumerable<Users>> GetUsersAsync(string search = null)
        {
            List<TourAPI.Models.Users> user = await _ctx.Users.ToListAsync();

            return user.Select(Mapper.Mapper.MapUsers);
        }

        public async Task SaveChangesAsync()
        {
            await _ctx.SaveChangesAsync();
        }

        public Task UpdateUserAsync(Users user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UserExistsAsync(int userid)
        {
            return await _ctx.Users.AnyAsync(u => u.UserId == userid);
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
