using MFEstrategyMaker.Stores.RegistersPage;

namespace MFEstrategyMaker.Commands.RegistersCommands
{
    public class GetRegistersDataCollectionCommand : CommandBase
    {
        private readonly DataCollectionsStore _dataCollectionsStore;

        public GetRegistersDataCollectionCommand()
        {
            //_dataCollectionsStore = "teste";
        }

        public override void Execute(object? parameter)
        {
            //_dataCollectionsStore.DataCollection = _createViewModel();
        }
    }
}
