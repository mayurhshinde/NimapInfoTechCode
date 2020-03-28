using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NimapInfoTechCode.Core.Entities
{
    public class ProductMaster
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(1000)]
        public string Name { get; set; }
         
        public int CategoryId { get; set; }
        public virtual CategoryMaster CategoryMaster { get; set; }
        public bool IsActive { get; set; }
    }
}
