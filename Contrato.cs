using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tarefaa.Entidades
{
    class Contrato
    {
        public int Numero { get; protected set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }

        public Contrato() 
        {

        }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public virtual double CalcularPrestacao()
        {
            return 0;

        }
        public virtual string Intel()
        {
            return " ";
        }

    }

}
