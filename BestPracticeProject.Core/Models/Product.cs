using System;
using System.Collections.Generic;
using System.Text;

namespace BestPracticeProject.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public int Stok { get; set; }

        public int KatagoriId { get; set; }

        public decimal Price { get; set; }

        public string InnerBarcode { get; set; }

        public virtual Katagori Katagori{ get; set; }


    }
}