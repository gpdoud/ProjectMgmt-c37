using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectMgmt.Models {

    public class Resource {

        public int Id { get; set; } = 0;
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
        public int HoursPerDay { get; set; } = 0;

        public int? ProjectId { get; set; } = null;
        public Project? Project { get; set; } = null;

        public IEnumerable<Work>? Works { get; set; } = null;

    }
}

