using MFE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Stores.RegistersStore
{
    public class DbTablesNameStore
    {
        public event Action<DbTablePropsModel> DbTableCreated;
        public event Action<DbTablePropsModel> DbTableUpdate;

        public async Task Create(DbTablePropsModel dbTablePropsModel)
        {
            DbTableCreated?.Invoke(dbTablePropsModel);
        }
        public async Task Update(DbTablePropsModel dbTablePropsModel)
        {
            DbTableUpdate?.Invoke(dbTablePropsModel);
        }
    }
}
