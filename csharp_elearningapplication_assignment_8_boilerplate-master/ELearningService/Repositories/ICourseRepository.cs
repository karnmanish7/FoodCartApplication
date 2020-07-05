using ELearningService.Models;
using System.Collections.Generic;

namespace ELearningService.Repositories
{
    public interface ICourseRepository
    {
        int CreateCourse(Course course);
        List<Course> Get();
        Course Get(int courseId);
        Course Get(string courseTitle);
    }
}
