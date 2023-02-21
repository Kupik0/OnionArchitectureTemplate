using ProductApp.Application.Dto;
using ProductApp.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppplication.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewDto>> GetAllProducts();
    }
}