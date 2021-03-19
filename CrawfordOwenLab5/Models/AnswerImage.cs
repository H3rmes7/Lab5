using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CrawfordOwenLab5;

namespace CrawfordOwenLab5.Models
{
    public enum Question 
    { 
        Earth, Computer
    
    }
    public class AnswerImage
    {

        public int AnswerImageId { get; set; }

        [Required]
        [DisplayName("FileName")]
        public string FileName { get; set; }

        [Required]
        [DisplayName("URL")]
        [Url]
        public string Url { get; set; }

        [Required]
        [DisplayName("Question")]
        public Question Question { get; set; }

    }
}
