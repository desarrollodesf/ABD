using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBConnection.Models
{
    public class Resultado
    {
        public string resultado;

        public DateTime startPunto1 { get; set; }
        public DateTime startPunto2 { get; set; }
        public DateTime startPunto3 { get; set; }
        public DateTime startPunto5 { get; set; }

        public DateTime endPunto1 { get; set; }
        public DateTime endPunto2 { get; set; }
        public DateTime endPunto3 { get; set; }
        public DateTime endPunto5 { get; set; }
    }
}
