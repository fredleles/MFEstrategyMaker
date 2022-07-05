using MFE.Domain.Models;
using System.Threading.Tasks;

namespace MFE.Domain.Commands
{
    public interface ICreateDataCollectionCommand
    {
        Task Execute(DataCollectionModel dataCollectionModel);
    }
}
