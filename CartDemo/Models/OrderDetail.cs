using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class OrderDetail {

        [Key]
        public string OrderId { get; set; }
        [Required(ErrorMessage = "Required")]
        public DateTime DateOfOrder { get; set; }

        public string DeliveryDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ProductId { get; set; }
        [ForeignKey("Customer")]
        [Required(ErrorMessage = "Required")]
        public string UserId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [Required(ErrorMessage = "Required")]
        public string CustomerName{get; set;}


    }
}