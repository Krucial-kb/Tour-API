using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tour.Domain.DomainModels;

namespace Tour.Domain.Interfaces
{
    public interface IUsersRepository : IDisposable
    {
        /// <summary>
        /// Return all users
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<IEnumerable<Users>> GetUsersAsync(string search = null);

        /// <summary>
        /// Return a user by UserID
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        Task<Users> GetUserByIdAsync(int userID);

        /// <summary>
        /// Search for a user by Username
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<Users> GetPatientByUsernameAsync(string userName);

        /// <summary>
        /// Checks to see if a user already exists
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        Task<bool> UserExistsAsync(int userid);

        /// <summary>
        /// Create new User Entity
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<Users> CreateUserAsync(Users user);

        /// <summary>
        /// Edit/Update Patient Info
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task UpdateUserAsync(Users user);

        /// <summary>
        /// Remove a user from the Database
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        Task DeleteUserAsync(int userID);
         EntityState Changed(Users user);
        Task SaveChangesAsync();
    }
}
