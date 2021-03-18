using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Commands.CreateProduct;
using Application.Features.Queries.GetAllProduct;
using Application.Features.Queries.GetByIdProduct;
using Application.Features.Queries.GetWhereProduct;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping.AutoMapper
{
    public class AutoMapper : Profile
    {

        public AutoMapper()
        {
            CreateMap<Product, GetAllProductQueryResponse>().ReverseMap();
            CreateMap<Product, GetByIdProductQueryResponse>().ReverseMap();
            CreateMap<Product, GetWhereProductQueryResponse>().ReverseMap();
        }
    }
}
