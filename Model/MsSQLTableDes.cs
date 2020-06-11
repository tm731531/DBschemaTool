using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBschemaTool.Model
{
    public class MsSQLTableDes
    {
        public string Table { get; set; }
        public string Column { get; set; }
        public string Isnull { get; set; }
        public int orderId { get; set; }
        public string DATA_TYPE { get; set; }
        public int? MaxLength { get; set; }
        public string Description { get; set; }
        public bool IsKey { get; set; }
    }
}
