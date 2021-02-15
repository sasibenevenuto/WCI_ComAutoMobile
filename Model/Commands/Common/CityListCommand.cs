using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Commands.Common
{
    public class CityListCommand
    {
        public int? EstadoId { get; set; }
        public string Cidade { get; set; }
        public int? PageNumber { get; set; }
        public int? RowspPage { get; set; }
    }
}
