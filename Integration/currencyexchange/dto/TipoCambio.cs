using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NebulaCars.Integration.currencyexchange.dto
{
    public class TipoCambio
    {
        public int Cantidad { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
    }
}