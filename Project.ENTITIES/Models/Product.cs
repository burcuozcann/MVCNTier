using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
   public class Product:BaseEntity
    {
        public string ProductName { get; set; }

        public string Description { get; set; }
        public int? CategoryID { get; set; }

        //Relational Properties

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
