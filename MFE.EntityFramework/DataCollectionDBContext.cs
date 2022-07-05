using MFE.EntityFramework.DTOs;
using Microsoft.EntityFrameworkCore;

namespace MFE.EntityFramework
{
    public class DataCollectionDBContext : DbContext
    {
        public DataCollectionDBContext(DbContextOptions options) : base(options) { }
        public DbSet<DataCollectionDTO> dataCollections { get; set; }
    }
}
