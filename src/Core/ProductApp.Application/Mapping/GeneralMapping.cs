using AutoMapper;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetProductById;
using ProductApp.Application.Features.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {

        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Product, Dto.ProductViewDto>()
                .ReverseMap();

            CreateMap<Domain.Entities.Product, CreateProductCommand>()
                .ReverseMap();

            CreateMap<Domain.Entities.Product, GetProductByIdViewModel>()
                .ReverseMap();
        }

    }
}