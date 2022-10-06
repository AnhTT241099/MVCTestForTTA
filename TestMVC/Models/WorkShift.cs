using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class WorkShift
    {
        public Guid IdWork { get; set; }
        public Guid IdShift { get; set; }
        public Guid Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public string? Status { get; set; }
        public Shift? Shift { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
