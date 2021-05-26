using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryGoods.Models
{
    public class DeliveryGoods
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Weight { get; set; }
        public string AddressArrival { get; set; }
        public string AddressDepature { get; set; }
        public string SurnameSender { get; set; }
        public string NameSender { get; set; }
        public string PatronymicSender { get; set; }
        public string PassportSeriesPatronimycSender { get; set; }
        public string PassportNumber { get; set; }
        public bool LocalDelivery { get; set; }
        public DateTime DateArrival { get; set; }
        public ICollection<Delivery> Delivery { get; set; }
    }
}
