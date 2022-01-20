using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_190_Ahmad_Ali.Models
{
    public class OrderClass
    {
        [Key]
        public int order_id { get; set; }

        [Required(ErrorMessage = "Enter Item Name")]
        [Display(Name = "Item Name")]
        public string name { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Required(ErrorMessage = "Enter Quantity")]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }

        [Required(ErrorMessage = "Enter Price")]
        [Display(Name = "Price")]
        public int price { get; set; }
    }
}
