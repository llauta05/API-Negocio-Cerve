using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace API_Negocio.Data
{
    [DataContract]
    public class StockData
    {
        [DataMember(Name = "nombreProducto")]
        public string NombreProducto { get; set; }
        [DataMember(Name = "stockReal")]
        public int StockReal { get; set; }
        [DataMember(Name ="stockPrevisto")]
        public int StockPrevisto { get; set; }
    }
}
