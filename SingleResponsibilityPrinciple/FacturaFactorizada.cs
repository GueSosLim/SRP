using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class FacturaFactorizada
    {
        public string Codigo { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal ImporteFactura { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteDeduccion { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal PorcentajeDeduccion { get; set; }

        /// <summary>
        /// Método que calcula el total de la factura
        /// </summary>
        public void CalcularTotal()
        {
            // Calculamos la deducción
            Deduccion deduccion = new Deduccion(PorcentajeDeduccion);
            ImporteDeduccion = deduccion.CalcularDeduccion(ImporteFactura);
            // Calculamos el IVA
            IvaNormal iva = new IvaNormal();
            ImporteIVA = iva.CalcularIVA(ImporteFactura);
            // Calculamos el total
            ImporteTotal = (ImporteFactura - ImporteDeduccion) + ImporteIVA;
        }
    }
}
