using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class IvaNormal
    {
        private const decimal PORCENTAJE_IVA_NORMAL = 0.16m;
        public decimal PorcentajeIvaNormal
        {
            get
            {
                return PORCENTAJE_IVA_NORMAL;
            }
        }

        public decimal CalcularIVA(decimal importe)
        {
            return importe * PORCENTAJE_IVA_NORMAL;
        }
    }
}
