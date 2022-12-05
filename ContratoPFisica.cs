using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tarefaa.Entidades
{
    class ContratoPFisica : Contrato
    {
        public string Cpf { get; protected set; }
        public int IdadeContratante { get; set; }

        public ContratoPFisica()
        {

        }
        public ContratoPFisica(int numero, string contratante, double valor, int prazo, string cpf, int idadeContratante) : base(numero, contratante, valor, prazo)
        {
            Cpf = cpf;
            IdadeContratante = idadeContratante;
        }

        public override double CalcularPrestacao()
        {
            if (IdadeContratante <= 30)
            {
                return (Valor / Prazo) + 1;
            }
            else if (IdadeContratante <= 40)
            {
                return (Valor / Prazo) + 2;
            }
            else if (IdadeContratante <= 50)
            {
                return (Valor / Prazo) + 3;
            }
            else
            {
                return (Valor / Prazo) + 3;
            }

        }

        public override string Intel()
        {
            return " - Número: "
                + Numero
                + "\n - Valor: $"
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + "\n - Prazo: "
                + Prazo
                + " meses"
                + "\n - Valor Prestação: $"
                + CalcularPrestacao().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
 