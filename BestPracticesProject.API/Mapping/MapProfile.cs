using AutoMapper;
using BestPracticeProject.Core.Models;
using BestPracticesProject.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPracticesProject.API.Maping
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
