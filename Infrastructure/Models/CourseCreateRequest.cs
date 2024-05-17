﻿

using Infrastructure.Data.Entities;

namespace Infrastructure.Models;

public class CourseCreateRequest
{
    public bool IsBestSeller { get; set; } = false;
    public string? CourseImage { get; set; }
    public string? CourseImageAltText { get; set; }
    public string Title { get; set; } = null!;
    public string? Price { get; set; }
    public string? DiscountPrice { get; set; }
    public string? Rating { get; set; }
    public string? Reviews { get; set; }
    public string? Views { get; set; }
    public string? LikesInPercent { get; set; }
    public string? LikesInNumbers { get; set; }


    // AutherInfo
    public string? AuthorName { get; set; }
    public string? AutherBio { get; set; }
    public string? AuthorImage { get; set; }
    public string? AutherImageAltText { get; set; }
    public string? YouTubeSubscribers { get; set; }
    public string? FaceBookFollowers { get; set; }

    // CourseDetails
    public string? ShowcaseImage { get; set; }
    public string? CourseDescription { get; set; }
    public string? ViewHours { get; set; }
    public string? Articles { get; set; }
    public string? Resources { get; set; }
    public string? AccessTime { get; set; }
    public List<string>? ProgramDetailsTitle { get; set; }
    public List<string>? ProgramDetailsText { get; set; }
    public List<string>? LearnPoints { get; set; }
    public virtual CategoryCreateRequest? Category { get; set; }
}

public class CategoryCreateRequest
{
    public string? CategoryName { get; set; }
}