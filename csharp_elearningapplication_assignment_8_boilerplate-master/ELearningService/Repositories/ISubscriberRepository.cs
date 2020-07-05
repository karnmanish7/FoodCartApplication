using ELearningService.Models;
using System.Collections.Generic;

namespace ELearningService.Repositories
{
    public interface ISubscriberRepository
    {
        bool Subscribe(Subscriber subscriber);
        List<Subscriber> Get();
        Subscriber Get(string userName);
        List<Subscriber> Get(int courseId);
    }
}
