﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TTSHOP.Model.Abstract;

namespace TTSHOP.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        public int? DisplayOrder { get; set; }

        public int? ParentID { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}