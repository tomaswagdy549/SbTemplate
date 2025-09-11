using App.Application.Interfaces.Repositories;
using SbTemplate.Core.Entities;
using SbTemplate.Core.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbTemplate.Application.Interfaces.SpesificRepository
{
 public   interface IProductRepository:IBaseRepository<Product>       
    {
        Task<bool> IsProductNameUnique(string name, Guid? id = null);   
    }
}
