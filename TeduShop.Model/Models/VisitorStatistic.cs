﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic : IdentityUser
    { 
        [Key]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisitedDate { set; get; }
        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
