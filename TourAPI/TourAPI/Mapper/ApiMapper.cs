using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourAPI.ApiModels;

namespace TourAPI.Mapper
{
    public class ApiMapper
    {
        //-------------------------------------------------------------------------
        //-------------------------------------------------------------------------
        //--------------------Map ApiModels to DomainModels------------------------
        //-------------------------------------------------------------------------
        //-------------------------------------------------------------------------

        public static ApiUsers MapUsersApi (Tour.Domain.DomainModels.Users users)
        {
            return new ApiUsers
            {
                UserId = users.UserId,
                FirstName = users.FirstName,
                LastName = users.LastName,
                UserName = users.UserName,
                Email = users.Email,
                Password = users.Password,
                Posts = users.Posts,
                ProfilePic = users.ProfilePic
            };
        }

        public static ApiPosts MapPostsApi (Tour.Domain.DomainModels.Posts posts)
        {
            return new ApiPosts
            {
                PostId = posts.PostId,
                Title = posts.Title,
                Comment = posts.Comment,
                Media = posts.Media
            };
        }

        public static ApiPostDetails MapPostDetails(Tour.Domain.DomainModels.PostDetails details)
        {
            return new ApiPostDetails
            {
                DetailsId = details.DetailsId,
                PostId = details.PostId,
                UserId = details.UserId,
                Quantity = details.Quantity,
                TimeStamp = details.TimeStamp
            };
        }
    }
}
