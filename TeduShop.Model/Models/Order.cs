﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(250)]
        public string CustomerName { set; get; }
        [MaxLength(250)]
        public string CustomerAddress { set; get; }
        [MaxLength(250)]
        public string CustomerEmail { set; get; }
        [MaxLength(50)]
        public string CustomerMobile { set; get; }
        [MaxLength(250)]
        public string CustomerMessage { set; get; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        [MaxLength(250)]
        public string PaymentMethod { set; get; }
        [MaxLength(50)]
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }
    }
}