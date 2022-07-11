using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFE.Domain.Models
{
    public class DbTablePropsModel
    {
        public Guid Id { get; }
        public string TableNameId { get; }

        public DbTablePropsModel(Guid id, string tableNameId)
        {
            Id = id;
            TableNameId = tableNameId;
        }
    }
}
