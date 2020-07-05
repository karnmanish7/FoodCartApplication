using ELearningService.Models;
using System.Collections.Generic;
using System.Linq;

namespace ELearningService.Repositories
{
    public class SubscriberRepository : ISubscriberRepository
    {
        readonly List<Subscriber> subscribers;

        public SubscriberRepository()
        {
            subscribers = new List<Subscriber>();
        }
        public List<Subscriber> Get()
        {
            return subscribers;
        }

        public Subscriber Get(string userName)
        {
            return subscribers.Where(s => s.UserName == userName).FirstOrDefault();
        }

        public List<Subscriber> Get(int courseId)
        {
            return subscribers.Where(s => s.CourseId == courseId).ToList();
        }

        public bool Subscribe(Subscriber subscriber)
        {
            if (Get(subscriber.UserName) == null)
            {
                subscribers.Add(subscriber);
                return true;
            }
            throw new InvalidInputException($"User with Username {subscriber.UserName} Already Exists !!!");

        }
    }
}
