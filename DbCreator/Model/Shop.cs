using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCreator.Model
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }
        [MaxLength(256)]
        [Required]
        public string ShopName { get; set; }
        [MaxLength(1024)]
        public string ShopAddress { get; set; }
        [MaxLength(1024)]
        public string WorkingTime { get; set; }
        public virtual List<Product> Products { get; set; }

        public Shop()
        {
            Products = new List<Product>();
        }
    }
}
