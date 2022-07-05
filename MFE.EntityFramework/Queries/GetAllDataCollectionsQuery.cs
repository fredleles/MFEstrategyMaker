using MFE.Domain.Models;
using MFE.Domain.Queries;
using MFE.EntityFramework.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFE.EntityFramework.Queries
{
    public class GetAllDataCollectionsQuery : IGetAllDataCollectionsQuery
    {
        private readonly DataCollectionDBContextFactory _contextFactory;

        public GetAllDataCollectionsQuery(DataCollectionDBContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<DataCollectionModel>> Execute()
        {
            using (DataCollectionDBContext context = _contextFactory.Create())
            {
                IEnumerable<DataCollectionDTO> dataCollectionDTOs = await context.dataCollections.ToListAsync();

                return dataCollectionDTOs.Select(y => new DataCollectionModel(y.Id, y.Type, y.CollectionName));
            }
        }
    }
}
