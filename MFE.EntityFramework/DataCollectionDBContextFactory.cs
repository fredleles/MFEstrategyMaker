using Microsoft.EntityFrameworkCore;

namespace MFE.EntityFramework
{
    public class DataCollectionDBContextFactory
    {
        private readonly DbContextOptions _options;

        public DataCollectionDBContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public DataCollectionDBContext Create()
        {
            return new DataCollectionDBContext(_options);
        }
    }
}
