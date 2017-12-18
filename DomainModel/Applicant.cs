using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Applicant
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }

        //public int UserId { get; set; }

        public ApplicationUser User { get; set; }

        public IEnumerable<ApplicationForVisa> Apllications { get; set; }

        public Applicant()
        {
            Apllications = new List<ApplicationForVisa>();
        }
    }
}
