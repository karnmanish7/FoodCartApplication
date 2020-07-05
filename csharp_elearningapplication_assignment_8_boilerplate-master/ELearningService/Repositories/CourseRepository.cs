using ELearningService.Models;
using System.Collections.Generic;
using System.Linq;

namespace ELearningService.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        static List<Course> courses;
        public CourseRepository()
        {
            courses = new List<Course>();
        }
        public int CreateCourse(Course course)
        {
            if (Get(course.CourseTitle) == null)
            {
                int courseId = 101;
                if (courses.Count > 0)
                    courseId = courses.Max(c => c.CourseId) + 1;

                course.SetCourseId(courseId);
                courses.Add(course);

                return courseId;
            }
            return 0;
        }

        public List<Course> Get()
        {
            return courses;
        }

        public Course Get(int courseId)
        {
            return courses.Where(c => c.CourseId == courseId).FirstOrDefault();
        }

        public Course Get(string courseTitle)
        {
            return courses.Where(c => c.CourseTitle == courseTitle).FirstOrDefault();
        }
    }
}
