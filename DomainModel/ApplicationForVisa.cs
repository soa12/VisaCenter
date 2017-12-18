using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class ApplicationForVisa
    {

        public int Id { get; set; }

        public string Date { get; set; }

        public int ApplicantId { get; set; }

        public string Status { get; set; }

        public byte[] Photo { get; set; }

        public byte[] Passport { get; set; }

        public byte[] BankStatement { get; set; }

        public byte[] InternationalPassport { get; set; }

        public byte[] MedicalInsurance { get; set; }

        public Applicant Applicant { get; set; }

    }
}
