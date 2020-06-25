using System;
using System.Collections.Generic;
using System.Text;

namespace Tour.DataAccess.Mapper
{
    public class Mapper
    {

        //-------------------------------------------------------------------------
        //-------------------------------------------------------------------------
        //-----------------------Map Domain to DbModels----------------------------
        //-------------------------------------------------------------------------
        //-------------------------------------------------------------------------

        public static Domain.DomainModels.Users MapUsers(TourAPI.Models.Users user)
        {
            return new Domain.DomainModels.Users
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                Posts = user.Posts,
                ProfilePic = user.ProfilePic
            };
        }

        public static Domain.DomainModels.Posts MapPosts(TourAPI.Models.Posts posts)
        {
            return new Domain.DomainModels.Posts
            {
                PostId = posts.PostId,
                Title = posts.Title,
                Media = posts.Media,
                Comment = posts.Comment
            };
        }

        public static Domain.DomainModels.PostDetails MapPostDetails(TourAPI.Models.PostDetails details)
        {
            return new Domain.DomainModels.PostDetails
            {
                DetailsId = details.DetailsId,
                UserId = details.UserId,
                PostId = details.PostId,
                Quantity = details.Quantity,
                TimeStamp = details.TimeStamp
            };
        }


        //-------------------------------------------------------------------------
        //-------------------------------------------------------------------------
        //-----------------------Map DbModels to Domain----------------------------
        //-------------------------------------------------------------------------
        //-------------------------------------------------------------------------

        public static TourAPI.Models.Users MapUsers(Domain.DomainModels.Users user)
        {
            return new TourAPI.Models.Users
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                Password = user.Password,
                Posts = user.Posts,
                ProfilePic = user.ProfilePic
            };
        }

        public static TourAPI.Models.Posts MapPosts(Domain.DomainModels.Posts posts)
        {
            return new TourAPI.Models.Posts
            {
                PostId = posts.PostId,
                Title = posts.Title,
                Media = posts.Media,
                Comment = posts.Comment
            };
        }

        public static TourAPI.Models.PostDetails MapPostDetails(Domain.DomainModels.PostDetails details)
        {
            return new TourAPI.Models.PostDetails
            {
                DetailsId = details.DetailsId,
                UserId = details.UserId,
                PostId = details.PostId,
                Quantity = details.Quantity,
                TimeStamp = details.TimeStamp
            };
        }
    }
}
