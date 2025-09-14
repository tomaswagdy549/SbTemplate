using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Core.Interfaces.GenericRepositoryInterface
{
    public interface IGetById<T>
    {
        Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
