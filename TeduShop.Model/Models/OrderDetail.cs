﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }
        [Key]
        public int ProductID { set; get; }
        public int Quality { set; get; }
        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        
    }
}
