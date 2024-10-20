﻿using System.ComponentModel.DataAnnotations;

namespace KinstonBackend.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public int ProfessorId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int NumberOfModules { get; set; }

        public string[] ModuleNames { get; set; } // Array of module names

        // New property to track if the course is approved
        public bool IsApproved { get; set; } = false; // Defaults to false for pending approval

    }
}