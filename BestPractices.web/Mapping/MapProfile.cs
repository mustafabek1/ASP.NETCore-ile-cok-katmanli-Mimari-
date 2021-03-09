using AutoMapper;
using BestPracticeProject.Core.Models;
using BestPracticesProject.web.DTO;
using BestPracticesProject.web.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPracticesProject.web.Maping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Katagori, KatagoriDto>();
            CreateMap<KatagoriDto, Katagori>();

            CreateMap<Katagori, KatagoriWithProductDto>();
            CreateMap<KatagoriWithProductDto, Katagori>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Product, ProductWithKatagoriDto>();
            CreateMap<ProductWithKatagoriDto, Product>();
        }
    }
}
