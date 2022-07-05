using MFE.Domain.Commands;
using MFE.EntityFramework.DTOs;
using System;
using System.Threading.Tasks;

namespace MFE.EntityFramework.Commands
{
    public class DeleteDataCollectionCommand : IDeleteDataCollectionCommand
    {
        private readonly DataCollectionDBContextFactory _contextFactory;

        public DeleteDataCollectionCommand(DataCollectionDBContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid id)
        {
            using (DataCollectionDBContext context = _contextFactory.Create())
            {
                DataCollectionDTO dataCollectionDTO = new DataCollectionDTO()
                {
                    Id = id,
                };

                context.dataCollections.Remove(dataCollectionDTO);
                await context.SaveChangesAsync();
            }
        }
    }
}
