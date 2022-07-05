using MFE.Domain.Commands;
using MFE.Domain.Models;
using MFE.EntityFramework.DTOs;
using System.Threading.Tasks;

namespace MFE.EntityFramework.Commands
{
    public class CreateDataCollectionCommand : ICreateDataCollectionCommand
    {
        private readonly DataCollectionDBContextFactory _contextFactory;

        public CreateDataCollectionCommand(DataCollectionDBContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(DataCollectionModel dataCollectionModel)
        {
            using (DataCollectionDBContext context = _contextFactory.Create())
            {
                DataCollectionDTO dataCollectionDTO = new DataCollectionDTO()
                {
                    Id = dataCollectionModel.Id,
                    Type = dataCollectionModel.Type,
                    CollectionName = dataCollectionModel.CollectionName,
                };

                context.dataCollections.Add(dataCollectionDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
