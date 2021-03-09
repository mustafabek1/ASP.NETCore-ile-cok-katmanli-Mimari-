using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPracticesProject.web.DTO
{
    public class ProductWithKatagoriDto:ProductDto
    {
        public KatagoriDto katagori { get; set; }
    }
}
