using System;

namespace MFE.EntityFramework.DTOs
{
    public class DataCollectionDTO
    {
        public Guid Id { get; set; }
        public string CollectionName { get; set; }
        public string Type { get; set; }
    }
}
