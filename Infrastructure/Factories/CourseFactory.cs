


using Infrastructure.Data.Entities;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using static HotChocolate.ErrorCodes;

namespace Infrastructure.Factories;

public static class CourseFactory
{
    public static CourseEntity Create(CourseCreateRequest request)
    {
        return new CourseEntity
        {
            Title = request.Title,
            IsBestSeller = request.IsBestSeller,
            CourseImage = request.CourseImage,
            CourseImageAltText = request.CourseImageAltText,
            Price = request.Price,
            DiscountPrice = request.DiscountPrice,
            Rating = request.Rating,
            Reviews = request.Reviews,
            Views = request.Views,
            LikesInPercent = request.LikesInPercent,
            LikesInNumbers = request.LikesInNumbers,
            AuthorName = request.AuthorName,
            AutherBio = request.AutherBio,
            AuthorImage = request.AuthorImage,
            AutherImageAltText = request.AutherImageAltText,
            YouTubeSubscribers = request.YouTubeSubscribers,
            FaceBookFollowers = request.FaceBookFollowers,
            ShowcaseImage = request.ShowcaseImage,
            Articles = request.Articles,         
            CourseDescription = request.CourseDescription,
            ViewHours = request.ViewHours,
            Resources = request.Resources,
            AccessTime = request.AccessTime,
            ProgramDetailsTitle = request.ProgramDetailsTitle,
            ProgramDetailsText = request.ProgramDetailsText,
            LearnPoints = request.LearnPoints,

            Category = request.Category == null ? null : new CategoryEntity
            {
                CategoryName = request.Category.CategoryName
            }
        };
      
    }

    public static CourseEntity Create(CourseUpdateRequest request)
    {
        return new CourseEntity
        {
            Id = request.Id,
            Title = request.Title,
            IsBestSeller = request.IsBestSeller,
            CourseImage = request.CourseImage,
            CourseImageAltText = request.CourseImageAltText,
            Price = request.Price,
            DiscountPrice = request.DiscountPrice,
            Rating = request.Rating,
            Reviews = request.Reviews,
            Views = request.Views,
            LikesInPercent = request.LikesInPercent,
            LikesInNumbers = request.LikesInNumbers,
            AuthorName = request.AuthorName,
            AutherBio = request.AutherBio,
            AuthorImage = request.AuthorImage,
            AutherImageAltText = request.AutherImageAltText,
            YouTubeSubscribers = request.YouTubeSubscribers,
            FaceBookFollowers = request.FaceBookFollowers,
            ShowcaseImage = request.ShowcaseImage,
            Articles = request.Articles,
            CourseDescription = request.CourseDescription,
            ViewHours = request.ViewHours,
            Resources = request.Resources,
            AccessTime = request.AccessTime,
            ProgramDetailsTitle = request.ProgramDetailsTitle,
            ProgramDetailsText = request.ProgramDetailsText,
            LearnPoints = request.LearnPoints,

            Category = request.Category == null ? null : new CategoryEntity
            {
                CategoryName = request.Category.CategoryName
            }
        };

    }

    public static Course Create(CourseEntity entity)
    {
        return new Course()
        {
            Id = entity.Id,
            Title = entity.Title,
            IsBestSeller = entity.IsBestSeller,
            CourseImage = entity.CourseImage,
            CourseImageAltText = entity.CourseImageAltText,
            Price = entity.Price,
            DiscountPrice = entity.DiscountPrice,
            Rating = entity.Rating,
            Reviews = entity.Reviews,
            Views = entity.Views,
            LikesInPercent = entity.LikesInPercent,
            LikesInNumbers = entity.LikesInNumbers,
            AuthorName = entity.AuthorName,
            AutherBio = entity.AutherBio,
            AuthorImage = entity.AuthorImage,
            AutherImageAltText = entity.AutherImageAltText,
            YouTubeSubscribers = entity.YouTubeSubscribers,
            FaceBookFollowers = entity.FaceBookFollowers,
            ShowcaseImage = entity.ShowcaseImage,
            Articles = entity.Articles,
            CourseDescription = entity.CourseDescription,
            ViewHours = entity.ViewHours,
            Resources = entity.Resources,
            AccessTime = entity.AccessTime,
            ProgramDetailsTitle = entity.ProgramDetailsTitle,
            ProgramDetailsText = entity.ProgramDetailsText,
            LearnPoints = entity.LearnPoints,

            Category = entity.Category == null ? null : new Category
            {
                Id = entity.Category.Id,
                CategoryName = entity.Category.CategoryName,
            }            
        };           
    }
}
