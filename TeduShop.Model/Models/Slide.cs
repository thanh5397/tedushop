﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Description { set; get; }

        [Required]
        public string Image { set; get; }

        [Required]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}