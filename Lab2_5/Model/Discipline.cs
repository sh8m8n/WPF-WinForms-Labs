using System;

namespace Model
{
    public class Discipline
    {
        public string Title { get; set; }
        public string TeacherName { get; set; }

        public Difficulty Difficulty { get; set; }

        public DateTime ExamDate { get; set; }
        public DateTime PreparetionStart { get; set; }

        public Discipline(string title, string teacherName, DateTime examDate, Difficulty difficulty)
        {
            Title = title;
            TeacherName = teacherName;
            Difficulty = difficulty;
            PreparetionStart = examDate;
            ExamDate = examDate;

            switch(Difficulty)
            {
                case Difficulty.Normal:
                    PreparetionStart.AddDays(-14);
                    break;

                case Difficulty.Hard:
                    PreparetionStart.AddMonths(-1);
                    break;

                default:
                    break;
            }
        }
    }
}
