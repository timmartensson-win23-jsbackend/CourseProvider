
using Infrastructure.Data.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Infrastructure.Services.CourseService;

namespace Infrastructure.Services;

public interface ICourseService
{
    Task<Course> CreateCourseAsync(CourseCreateRequest request);

    Task<Course> GetCourseByIdAsync(string id);

    Task<IEnumerable<Course>> GetCoursesAsync();

    Task<Course> UpdateCourseAsync(CourseUpdateRequest request);

    Task<bool> DeleteCourseAsync(string id);
}

public class CourseService(IDbContextFactory<DataContext> contextFactory, ILogger<CourseService> logger) : ICourseService
{
    private readonly IDbContextFactory<DataContext> _contextFactory = contextFactory;
    private readonly ILogger<CourseService> _logger = logger;



    public async Task<Course> CreateCourseAsync(CourseCreateRequest request)
    {
        await using var context = _contextFactory.CreateDbContext();

        var courseEntity = CourseFactory.Create(request);
        context.Courses.Add(courseEntity);
        await context.SaveChangesAsync();

        return CourseFactory.Create(courseEntity);

    }
   

    public class CreateCourseResponse
    {
        public string Id { get; set; } = null!;
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
    public async Task<bool> DeleteCourseAsync(string id)
    {
        try
        {
            await using var context = _contextFactory.CreateDbContext();

            var courseEntity = await context.Courses.FirstOrDefaultAsync(x => x.Id == id);
            if (courseEntity == null)
            {
                _logger.LogInformation("Course with ID {Id} not found for deletion", id);
                return false;
            }
            context.Courses.Remove(courseEntity);
            await context.SaveChangesAsync();
            _logger.LogInformation("Course with ID {Id} deleted successfully", id);
            return true;
        }
        catch (Exception ex) 
        {
            _logger.LogError(ex, "An error occurred while deleting course with ID {Id}", id);
            return false;
        }
       
      
    }

    public async Task<Course> GetCourseByIdAsync(string id)
    {
        await using var context = _contextFactory.CreateDbContext();
        var courseEntity = await context.Courses.FirstOrDefaultAsync(x => x.Id == id);

        return courseEntity == null ? null! : CourseFactory.Create(courseEntity);
    }

    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        await using var context = _contextFactory.CreateDbContext();
        var courseEntities = await context.Courses.ToListAsync();

        return courseEntities.Select(CourseFactory.Create);
    }

    public async Task<Course> UpdateCourseAsync(CourseUpdateRequest request)
    {
        await using var context = _contextFactory.CreateDbContext();
        var existingCourse = await context.Courses.FirstOrDefaultAsync(x => x.Id == request.Id);
        if (existingCourse == null) return null!;

        var updateCourseEntity = CourseFactory.Create(request);
        updateCourseEntity.Id = existingCourse.Id;
        context.Entry(existingCourse).CurrentValues.SetValues(updateCourseEntity);

        await context.SaveChangesAsync();
        return CourseFactory.Create(existingCourse);
               

    }
}
