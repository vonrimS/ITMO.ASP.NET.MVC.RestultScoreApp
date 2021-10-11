using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResultScoreApp.Models
{
    public class ResultScoreAppContext : DbContext

    {
        public DbSet<Score> Scores { get; set; }
        public DbSet<Student> Students { get; set; }

    }
        public class ResultScoreDbInitializer : DropCreateDatabaseAlways<ResultScoreAppContext>
        {
            protected override void Seed(ResultScoreAppContext context)
            {
                //context.Groups.Add(new Group { Name = "Бизнес-информатика", ShortName = "БИ-2101" });
                //context.Groups.Add(new Group { Name = "Информационная безопасность", ShortName = "ИБ-2102" });
                //context.Groups.Add(new Group { Name = "Информационные системы", ShortName = "ИС-2103" });
                //context.Groups.Add(new Group { Name = "Бизнес-информатика", ShortName = "БИ-2104" });

                context.Students.Add(new Student { LastName = "Азарин", FirstName = "Кирилл", SecondName = "Георгиевич" });
                context.Students.Add(new Student { LastName = "Айвазян", FirstName = "Карен", SecondName = "Гарикович" });
                context.Students.Add(new Student { LastName = "Бефус", FirstName = "Полина", SecondName = "Олеговна" });
                context.Students.Add(new Student { LastName = "Говоров", FirstName = "Никита", SecondName = "Георгиевич" });
                context.Students.Add(new Student { LastName = "Яценко", FirstName = "Кирилл", SecondName = "Александрович" });
                context.Students.Add(new Student { LastName = "Горбунков", FirstName = "Семен", SecondName = "Сергеевич" });
                context.Students.Add(new Student { LastName = "Куйбышев", FirstName = "Кирилл", SecondName = "Борисович" });
                context.Students.Add(new Student { LastName = "Мурашко", FirstName = "Анна", SecondName = "Дмитриевна" });
                context.Students.Add(new Student { LastName = "Куценко", FirstName = "Дарья", SecondName = "Романовна" });
                context.Students.Add(new Student { LastName = "Лысин", FirstName = "Данил", SecondName = "Максимович" });
                context.Students.Add(new Student { LastName = "Яровой", FirstName = "Николай", SecondName = "Валентинович" });

                //Score s1 = new Score { Id = 1, StudentId = 1, SubjectId = 1, ScoreValue = 50 };
                //Score s2 = new Score { Id = 2, StudentId = 1, SubjectId = 2, ScoreValue = 40 };
                //Score s3 = new Score { Id = 3, StudentId = 1, SubjectId = 3, ScoreValue = 35 };
                //Score s4 = new Score { Id = 4, StudentId = 1, SubjectId = 4, ScoreValue = 20 };
                //Score s5 = new Score { Id = 5, StudentId = 1, SubjectId = 5, ScoreValue = 60 };
                //Score s6 = new Score { Id = 6, StudentId = 1, SubjectId = 6, ScoreValue = 51 };

                //context.Subjects.Add(new Subject { Name = "ИАИО", ShortName = "Инженерные аспекты информационного общества" });
                //context.Subjects.Add(new Subject { Name = "ИЯ", ShortName = "Иностранный язык" });
                //context.Subjects.Add(new Subject { Name = "ИСиТ", ShortName = "Информационные системы и технологии" });
                //context.Subjects.Add(new Subject { Name = "ЛА", ShortName = "Линейная алгебра" });
                //context.Subjects.Add(new Subject { Name = "ПАСИС", ShortName = "Программно-аппаратные средства информационных систем" });
                //context.Subjects.Add(new Subject { Name = "ЦАП", ShortName = "Цифровая архитектура предприятия" });



                context.SaveChanges();

                //base.Seed(context);
            }
        }
    }
