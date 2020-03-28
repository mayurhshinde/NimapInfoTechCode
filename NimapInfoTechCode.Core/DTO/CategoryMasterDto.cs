using NimapInfoTechCode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NimapInfoTechCode.Core.DTO
{
    public class CategoryMasterDto
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public CategoryMaster category { get; set; }
    }
}
