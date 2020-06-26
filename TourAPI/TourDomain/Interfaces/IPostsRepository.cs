using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tour.Domain.DomainModels;

namespace Tour.Domain.Interfaces
{
    public interface IPostsRepository : IDisposable
    {
        Task<IEnumerable<Posts>> GetPostsAsync(Posts post);
        Task<Posts> GetPostsByIdAsync(int postID);
        Task<Posts> CreatePostAsync(Posts post);
        Task<bool> PostExistsAsync(int postID);
        EntityState Changed(Users user);
        Task UpdatePostAsync(Posts post);
        Task DeletePostAsync(int postID);
        Task SaveChangesAsync();
    }
}
