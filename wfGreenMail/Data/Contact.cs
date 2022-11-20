using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfGreenMail.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        public string? FName { get; set; }
        
        [StringLength(50)]
        public string LName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        
        public DateTime? Birthday { get; set; }
        
        
    }
}
