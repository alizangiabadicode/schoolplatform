using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myschool.Models
{
    public class EducationPayment
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
