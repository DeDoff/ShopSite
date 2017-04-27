using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbCreator.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(256)]
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public virtual List<Shop> Shops { get; set; }

        public Product()
        {
            Shops = new List<Shop>();
        }
    }
}
