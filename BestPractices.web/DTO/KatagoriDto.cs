using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestPracticesProject.web.DTO
{
    public class KatagoriDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0}Alan bos olmaz")]
        public string Name { get; set; }
    }
}
