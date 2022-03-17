using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class Cliente
    {
        public string Name { get; set; }
        public int CPF { get; set; }
        public string Endereco { get; set; }
        public int Agencia { get; set; }


        public Cliente() { }
    }
}
