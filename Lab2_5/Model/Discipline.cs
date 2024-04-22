using System;

namespace Model
{
    public class Discipline
    {
        public string Title { get; set; }
        public string TeacherName { get; set; }

        public Difficulty Difficulty { get; set; }

        public DateTime ExamDate { get; set; }
        public DateTime PreparationTime { get; set; }

        public Discipline(string title, string teacherName, DateTime examDate, Difficulty difficulty)
        {
            Title = title;
            TeacherName = teacherName;
            Difficulty = difficulty;
            ExamDate = examDate;

            switch(Difficulty)
            {
                case Difficulty.Normal:
                    try
                    {
                        PreparationTime = ExamDate.AddDays(-14);
                    }
                    catch { }
                    break;

                case Difficulty.Hard:
                    try
                    {
                        PreparationTime = ExamDate.AddMonths(-1);
                    }
                    catch { }
                    break;

                default:
                    PreparationTime = ExamDate;
                    break;
            }
        }
    }
}
