using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
   public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string Remarks { get; set; }
    }
}
