using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        //propriedades autoimplementadas
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        //metodo construtor
        public Cliente()
        {

        }
    }
}
