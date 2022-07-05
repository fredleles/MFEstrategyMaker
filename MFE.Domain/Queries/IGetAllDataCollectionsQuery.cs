using MFE.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MFE.Domain.Queries
{
    public interface IGetAllDataCollectionsQuery
    {
        Task<IEnumerable<DataCollectionModel>> Execute();
    }
}
