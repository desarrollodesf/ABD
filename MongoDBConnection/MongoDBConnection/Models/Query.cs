using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBConnection.Models
{
    public class Query

    {
        public string resultado;

        [DisplayName("Fecha Inicio")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime startPunto1 { get; set; }

        [DisplayName("Fecha Fin")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime startPunto2 { get; set; }
    }
}
