using MFE.Domain.Models;
using System;

namespace MFEstrategyMaker.Stores.RegistersPage
{
    public class DataCollectionsStore
    {
        public event Action RegisterDataCollectionChanged;
        private DataCollectionModel _dataCollection;

        public DataCollectionModel DataCollection
        {
            get { return _dataCollection; }
            set 
            { 
                _dataCollection = value;
                RegisterDataCollectionChanged?.Invoke();
            }
        }

    }
}
