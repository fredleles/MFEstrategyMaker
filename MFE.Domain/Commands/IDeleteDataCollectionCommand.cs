using System;
using System.Threading.Tasks;

namespace MFE.Domain.Commands
{
    public interface IDeleteDataCollectionCommand
    {
        Task Execute(Guid id);
    }
}
