using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sulekha.Models
{
    public class Business
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Business_ID { get; set; }
        public string Service_name { get; set; }
        public string Address { get; set; }
        public string Information { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }

        [ForeignKey("TypeName")]
        public string SubService_name { get; set; }
        public int TypeName { get; set; }
        public Doctor Doctor { get; set; }
        
    }
}
