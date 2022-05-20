using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMgmt.Models {

    public class Work {

        public int Id { get; set; } = 0;

        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        public int HoursWorked { get; set; } = 0;

        public int ResourceId { get; set; } = 0;
        public Resource? Resource { get; set; } = null;

    }
}

