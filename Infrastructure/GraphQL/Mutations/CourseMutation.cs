﻿

using Infrastructure.Models;
using Infrastructure.Services;
using static Infrastructure.Services.CourseService;

namespace Infrastructure.GraphQL.Mutations;

public class CourseMutation(ICourseService courseService)
{
    private readonly ICourseService _courseService = courseService;

    [GraphQLName("createCourse")]
    public async Task<Course> CreateCourseAsync(CourseCreateRequest input)
    {
        return await _courseService.CreateCourseAsync(input);
    }

    //[GraphQLName("createCourse")]
    //public async Task<CreateCourseResponse> CreateCourseAsync(CourseCreateRequest input)
    //{
    //    var course = await _courseService.CreateCourseAsync(input);
    //    return new CreateCourseResponse
    //    {
    //        Id = course.Id,
    //        Success = true,
    //        Message = "Course created successfully"
    //    };
    //}

    [GraphQLName("updateCourse")]
    public async Task<Course> UpdateCourseAsync(CourseUpdateRequest input)
    {
        return await _courseService.UpdateCourseAsync(input);
    }

    [GraphQLName("deleteCourse")]
    public async Task<bool> DeleteCourseAsync(string id)
    {
        return await _courseService.DeleteCourseAsync(id);
    }

}
