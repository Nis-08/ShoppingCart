using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class Merchant { 

        [Key]
        public string MerchantId{get; set;}
        [Required(ErrorMessage = "Required")]
        public string MerchantName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string ProductId { get; set; }
        [Required(ErrorMessage = "Required")]
        public string ProductName { get; set; }
    public string SellingPrice { get; set; }
    [ForeignKey("ProductId")]
    public Product Product { get; set; }


}
}