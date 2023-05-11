using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    { //classe
        public static int TotalDeContas { get; private set; }
        //static: passa a ser da classe e nao do objeto, vai p memoria do computador e acessa mais rapido
        private int numero_agencia;
        //ao inves do metodo da pra usar uma propriedade
        //propriedade (encapsula um campo privado e valida as propriedades):
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if(value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        //private string conta;
        //propriedade autoimplementada
        public string Conta { get; set; }

        //private Cliente titular;
        //vai receber uma referencia/objeto Cliente
        public Cliente Titular { get; set; }

        private double saldo = 100;
        //atributos
        public void Depositar(double valor)
        { //método Depositar , void é o valor que volta (nd)
            //dentro dos () é um parametro
            saldo += valor;
        }

        public bool Sacar(double valor)
        { //volta um booleano
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                /*this.saldo -= valor;
                destino.saldo += valor;*/
                return true;
            }
        }

        public void SetSaldo(double valor)
        { 
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        
        public double GetSaldo()
        {
            return this.saldo;
        }

        //construtor padrao
        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            //this aponta para o objeto

            TotalDeContas++;
        }

        
    }

}
