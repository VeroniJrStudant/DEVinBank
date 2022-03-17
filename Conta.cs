using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class Conta
    {
        public string nome { get; set; }
        public int cpf { get; set; }
        public string endereco { get; set; }
        public double rendaMensal { get; protected set; }
        public int  conta { get; set; }
        public string agencia { get; set; }



        public double Saldo { get; protected set; }


    }
}
