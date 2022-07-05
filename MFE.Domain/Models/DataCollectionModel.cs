using System;

namespace MFE.Domain.Models
{
    public class DataCollectionModel
    {
        public Guid Id { get; }
        public string CollectionName { get; }
        public string Type { get; }

        public DataCollectionModel(Guid id, string collectionName, string type)
        {
            Id = id;
            CollectionName = collectionName;
            Type = type;
        }
    }
}
