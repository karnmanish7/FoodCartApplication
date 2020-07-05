namespace ELearningService.Models
{
    public class Course
    {
        public int CourseId { get; private set; }
        public string CourseTitle { get; private set; }
        public int DurationInWeeks { get; private set; }
        public string Technology { get; private set; }
        public string Specialization { get; private set; }
        public int Fees { get; private set; }

        public Course(string courseTitle, int duration, string technology, string specialization, int fees)
        {
            SetCourseTitle(courseTitle);
            SetDurationInWeeks(duration);
            Technology = technology;
            Specialization = specialization;
            SetFees(fees);
        }

        public void SetCourseId(int courseId)
        {
            if (courseId >= 101)
            {
                CourseId = courseId;
            }
        }

        public void SetCourseTitle(string courseTitle)
        {
            if (courseTitle != null)
                CourseTitle = courseTitle;
            else
                throw new InvalidInputException($"Course Title Cannot be Null !!!");
        }

        public void SetDurationInWeeks(int duration)
        {
            if (duration >= 0)
                DurationInWeeks = duration;
            else
                throw new InvalidInputException($"Duration Cannot be a Negative Value !!!");
        }

        public void SetFees(int fees)
        {
            if (fees >= 0)
                Fees = fees;
            else
                throw new InvalidInputException($"Fees Cannot be a Negative Value !!!");
        }
    }
}
