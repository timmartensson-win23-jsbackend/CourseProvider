

using Infrastructure.Data.Entities;

namespace Infrastructure.GraphQL.ObjectTypes;

public class CourseType : ObjectType<CourseEntity>
{
    protected override void Configure(IObjectTypeDescriptor<CourseEntity> descriptor)
    {
        descriptor.Field(c => c.Id).Type<NonNullType<IdType>>();
        descriptor.Field(c => c.IsBestSeller).Type<BooleanType>();
        descriptor.Field(c => c.CourseImage).Type<StringType>();
        descriptor.Field(c => c.CourseImageAltText).Type<StringType>();
        descriptor.Field(c => c.Title).Type<NonNullType<StringType>>();
        descriptor.Field(c => c.Price).Type<StringType>();
        descriptor.Field(c => c.DiscountPrice).Type<StringType>();
        descriptor.Field(c => c.Rating).Type<StringType>();
        descriptor.Field(c => c.Reviews).Type<StringType>();
        descriptor.Field(c => c.Views).Type<StringType>();
        descriptor.Field(c => c.LikesInPercent).Type<StringType>();
        descriptor.Field(c => c.LikesInNumbers).Type<StringType>();
        descriptor.Field(c => c.AuthorName).Type<StringType>();
        descriptor.Field(c => c.AutherBio).Type<StringType>();
        descriptor.Field(c => c.AuthorImage).Type<StringType>();
        descriptor.Field(c => c.AutherImageAltText).Type<StringType>();
        descriptor.Field(c => c.YouTubeSubscribers).Type<StringType>();
        descriptor.Field(c => c.FaceBookFollowers).Type<StringType>();
        descriptor.Field(c => c.ShowcaseImage).Type<StringType>();
        descriptor.Field(c => c.CourseDescription).Type<StringType>();
        descriptor.Field(c => c.ViewHours).Type<StringType>();
        descriptor.Field(c => c.Articles).Type<StringType>();
        descriptor.Field(c => c.Resources).Type<StringType>();
        descriptor.Field(c => c.AccessTime).Type<StringType>();
        descriptor.Field(c => c.ProgramDetailsTitle).Type<ListType<StringType>>();
        descriptor.Field(c => c.ProgramDetailsText).Type<ListType<StringType>>();
        descriptor.Field(c => c.LearnPoints).Type<ListType<StringType>>();
        descriptor.Field(c => c.Category).Type<CategoryType>().Name("category");
    }

    public class CategoryType : ObjectType<CategoryEntity> 
    {
        protected override void Configure(IObjectTypeDescriptor<CategoryEntity> descriptor)
        {
            descriptor.Field(c => c.Id).Type<NonNullType<IdType>>();
            descriptor.Field(c => c.CategoryName).Type<StringType>();
        }
    }
}
