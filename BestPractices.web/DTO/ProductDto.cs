using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestPracticesProject.web.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} Alani gerkli")]
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="{0} Alani 1 den buyuk bir deger olmalidir.")]
        public int Stok { get; set; }

        public int KatagoriId { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "{0} Alani 1 den buyuk bir deger olmalidir.")]

        public decimal Price { get; set; }
    }
}
