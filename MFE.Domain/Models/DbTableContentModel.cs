using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFE.Domain.Models
{
    public class DbTableContentModel
    {
        public string TableNameId { get; }

        public DbTableContentModel(string tableNameId)
        {
            TableNameId = tableNameId;
        }
    }
}
