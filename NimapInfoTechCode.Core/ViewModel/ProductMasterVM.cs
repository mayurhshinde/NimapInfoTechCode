using NimapInfoTechCode.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NimapInfoTechCode.Core.ViewModel
{
    public class ProductMasterVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Select Category")]
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}
