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
     * For Assertions use NUnit Classic Model
     *
     */

    public class TestSubscriberRepository
    {
        ISubscriberRepository repository;


        #region positive_test_cases

        public void ShouldCreateFirstSubscriberWithStatusTrue()
        {
            
        }

        public void ShouldCreateNextSubscriberWithStatusTrue()
        {
            
        }

        public void ShouldGetAllSubscribers()
        {
            
        }

        public void ShouldGetSubscribersByCourseId(int courseId)
        {

        }

        #endregion

        #region negative_test_cases

        
        public void ShouldFailToCreateSubscriberWithDuplicateUserName()
        {
            
        }
         
        public void ShouldFailToCreateSubscriberWithNullEmail()
        {
            
        }
         
        public void ShouldReturnNullForNonExistingUserName(string userName)
        {

        }
         
        public void ShouldRetunEmptyListForNonExistingCourseId(int courseId)
        {

        }

        #endregion
    }
}
