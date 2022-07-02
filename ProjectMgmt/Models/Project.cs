using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMgmt.Models {

    public class Project {

        public int Id { get; set; } = 0;
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        public int EstimatedHours { get; set; } = 0;
        public int ActualHours { get; set; } = 0;
        public float PercentComplete { get; set; } = 0;
        [StringLength(15)]
        public string Status { get; set; } = string.Empty;


    }
}

