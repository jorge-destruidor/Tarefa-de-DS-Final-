using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tarefaa.Entidades
{
    class ContratoPJuridica : Contrato
    {
        public string Cnpj { get; protected set; }
        public string InscricaoEstadual { get; protected set; }
          public ContratoPJuridica()
        {
        }

        public ContratoPJuridica(int numero, string contratante, double valor, int prazo, string cnpj, string inscricaoEstadual) : base(numero, contratante, valor, prazo)
        {
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
        }

        public override double CalcularPrestacao()
        {

            return (Valor / Prazo) + 3;

        }

        public override string Intel()
        {
            return " - Número: "
                + Numero
                + "  /Valor: $"
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + " /Prazo: "
                + Prazo
                + " meses"
                + "  /Valor Prestação: $"
                + CalcularPrestacao().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}

 