using ProductApp.Application.Dto;

using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();

        Task<T> GetById(Guid id);

        Task<T> AddAsync(T entity);
    }
}