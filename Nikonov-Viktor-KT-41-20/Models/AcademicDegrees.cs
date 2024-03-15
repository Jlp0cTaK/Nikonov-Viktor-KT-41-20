using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Nikonov_Viktor_KT_41_20.Models
{
    public class AcademicDegrees
    {
        [Key]
        public int DegreeId { get; set; }
        public string? Degree { get; set; }
        public int? TeacherId { get; set; }
        public ICollection<Teachers>? Teachers { get; set; }
    }
}
