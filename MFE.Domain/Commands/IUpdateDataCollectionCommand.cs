using MFE.Domain.Models;
using System.Threading.Tasks;

namespace MFE.Domain.Commands
{
    public interface IUpdateDataCollectionCommand
    {
        Task Execute(DataCollectionModel dataCollectionModel);
    }
}
