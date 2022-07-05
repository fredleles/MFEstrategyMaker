using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFE.Domain.Models
{
    public class DataRegisterModel
    {
        public Guid Id { get; }
        public string Label { get; }
        public string Type { get; }

        // data JSON

        public DataRegisterModel(Guid id, string label, string type)
        {
            Id = id;
            Label = label;
            Type = type;
        }

    }
}
