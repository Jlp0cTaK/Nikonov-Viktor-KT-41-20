using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Nikonov_Viktor_KT_41_20.Models
{
    public class Disciplines
    {
        [Key]
        public int DisciplineId { get; set; }
        public string? DisciplineName { get; set; }
        public ICollection<Teachers>? Teachers { get; set; }

    }
}
