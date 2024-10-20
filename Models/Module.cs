﻿using System.ComponentModel.DataAnnotations;

namespace KinstonBackend.Models
{
    public class Module
    {
        [Key]
        public int ModuleId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public int CourseId { get; set; } // Foreign key to Course

        public Course Course { get; set; } // Navigation property to Course
    }
}
