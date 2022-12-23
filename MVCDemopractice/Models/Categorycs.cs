﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCDemopractice.Models
{
    public class Categorycs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="display order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
    }
}
