using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NimapInfoTechCode.Core.Entities
{ 
    public class CategoryMaster
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; } 
        public bool IsActive { get; set; }

        [ForeignKey("CategoryId")]
        public ICollection<ProductMaster> ProductMasters { get; set; }
    }
}
