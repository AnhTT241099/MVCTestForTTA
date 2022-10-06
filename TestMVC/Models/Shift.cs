using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Shift
    {
        public Guid IdShift { get; set; }
        [Column(TypeName = "NVARCHAR(30)")]
        public string? ShiftName { get; set; }
        public string? Time { get; set; }
        public ICollection<WorkShift> WorkShift { get; set; }
    }
}