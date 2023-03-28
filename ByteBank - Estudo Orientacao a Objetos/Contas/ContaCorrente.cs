using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank___Estudo_Orientacao_a_Objetos.Titular;

namespace ByteBank___Estudo_Orientacao_a_Objetos.Contas
{
    public class ContaCorrente
    {
        //valor padrão para INT e DOUBLE é 0
        //valor padrão para STRING é (NULL / vazio)
        //valor padrão para BOOL é false

        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;


        //CRIANDO METODOS

        public void Depositar(double valor)
        {
            //this representa o proprio objeto
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            //fazer verificação de o valor que for sacar for menor ou igual ao campo saldo
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

        //public bool Transferir(double valor, ContaCorrente destino)
        //{
        //    if (this.saldo < valor)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        this.Sacar(valor);
        //        destino.Depositar(valor);
        //        return true;
        //    }
        //}

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
    }
}
