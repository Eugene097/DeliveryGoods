using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryGoods.Models
{
    public class Delivermen
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string SurnameDelivermen { get; set; }
        public string NameDelivermen { get; set; }
        public string PatronymicDelivermen { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string AddressResidence { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Delivery> Delivery { get; set; }
    }
}
