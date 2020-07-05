using System;
using System.Configuration;

namespace ELearningService.Models
{
    public class Subscriber
    {
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public int CourseId { get; private set; }
        public DateTime DateOfSubscription { get; private set; }

        public Subscriber(string userName, string email, int courseId)
        {
            UserName = userName;
            SetEmail(email);
            CourseId = courseId;
            DateOfSubscription = DateTime.Now;
        }

        public void SetEmail(string email)
        {
            if (email != null)
                Email = email;
            else
                throw new InvalidInputException($"Email Cannot Be Null !!!");
        }

    }
}
