using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ResultScoreApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Отчество")]
        public string SecondName { get; set; }
        private string _FullName { get; set; }
        [Display(Name = "Фамилия Имя Отчество")]
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = LastName + " " + FirstName + " " + SecondName; }
        }

        public int? ScoreId { get; set; }
        public virtual Score Score { get; set; }

        public Student()
        {
            Score = new Score();
            ScoreId = Score.Id;         

        }
    }
}