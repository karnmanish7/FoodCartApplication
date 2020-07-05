using ELearningService.Models;
using ELearningService.Repositories;
using NUnit.Framework;
using System.Collections.Generic;

namespace ELearningApp.Test
{
    /*
     * 
     * Design NUnit Test Cases for CourseRepository
     * 
     * For Assertions use NUnit Constraint Model
     *
     */

    public class TestCourseRepository
    {
        readonly ICourseRepository repository;

        #region positive_test_cases

        public void ShouldCreateFirstCourseWithId101()
        {
            
        }

        public void ShouldCreateNextCourseWithId102()
        {
            
        }

        public void ShouldGetAllCourses()
        {
            
        }

        public void ShouldGetCourseById(int courseId)
        {
 
        }

        public void ShouldGetCourseById(string courseTitle)
        {

        }

        #endregion

        #region negative_test_cases

        public void ShouldFailToCreateCourseWithNullCourseTitle()
        {

           
        }
                
        public void ShouldFailToCreateCourseWithNegativeCourseFees()
        {
            
        }

        public void ShouldFailToCreateCourseWithNegativeCourseDuration()
        {

           
        }

        public void ShouldRetunNullForNonExistingCourseId(int courseId)
        {


        }

        public void ShouldRetunNullForNonExistingCourseTitle(string courseTitle)
        {

        }

        #endregion

    }
}
