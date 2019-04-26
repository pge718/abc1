
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sulekha.Models
{
    public class Appointment
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact_Number { get; set; }
        public int age { get; set; }
        public string timeSlot { get; set; }
        [Key]
        public int AID { get; set; }
        public string Email { get; set; }

        [ForeignKey("ID")]
        public int DoctorID { get; set; }

        public int ID { get; set; }
        public Doctor Doctor { get; set; }
        
    }
}
