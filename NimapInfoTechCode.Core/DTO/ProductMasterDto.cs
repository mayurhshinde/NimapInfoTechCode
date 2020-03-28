using NimapInfoTechCode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NimapInfoTechCode.Core.DTO
{ 
    public class ProductMasterDto
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public ProductMaster product { get; set; }

        public List<CategoryMaster> categories { get; set; }
    }
}
