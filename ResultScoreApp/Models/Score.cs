using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ResultScoreApp.Models
{
    public class Score
    {
        public int Id { get; set; }
        [Display(Name = "Математика")]

        public int Score1 { get; set; }
        [Display(Name = "ИЯ")]
        public int Score2 { get; set; }
        [Display(Name = "Adb")]
        public int Score3 { get; set; }
        [Display(Name = "Фамилия")]
        public int Score4 { get; set; }
        [Display(Name = "Фамилия")]
        public int Score5 { get; set; }
        [Display(Name = "Фамилия")]
        public int Score6 { get; set; }
        [Display(Name = "Фамилия")]
        private int _TotalScore { get; set; }
        public int TotalScore
        {
            get { return _TotalScore; }
            set { _TotalScore = Score1 + Score2 + Score3 + Score4 + Score5 + Score6; }
        }                
       
    }
}