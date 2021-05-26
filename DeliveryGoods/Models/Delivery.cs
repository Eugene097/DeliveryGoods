using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryGoods.Models
{
    public class Delivery
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int IDDeliveryman { get; set; }
        public int IDDeliveryGood { get; set; }
        public DateTime DateDeliver { get; set; }
    }
}
