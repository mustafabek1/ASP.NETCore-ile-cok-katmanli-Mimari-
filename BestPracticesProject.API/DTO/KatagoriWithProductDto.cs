using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPracticesProject.API.DTO
{
    public class KatagoriWithProductDto:KatagoriDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
