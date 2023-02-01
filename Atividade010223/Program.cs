using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade010223
{
    public class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta2 = new ContaCorrente();
            conta2.agencia = 51;
            conta2.conta = "123542-X";
            conta2.nome = "Astolfo";
            conta2.saldo = 250.00;



            Console.WriteLine("O saldo anterior é: R$" + conta2.saldo);
            conta2.sacar(137);
            Console.WriteLine("O saldo depois do saque é: " + conta2.saldo);

            /*ContaCorrente conta1 = new ContaCorrente();
            conta1.agencia = 51;
            conta1.conta = "123542-X";
            conta1.nome = "Astolfo";
            conta1.saldo = 250.00;
              
              
              
             Console.WriteLine("O saldo anterior é: R$" + conta1.saldo);
            conta1.Depositar(5000);
            Console.WriteLine("O saldo depois do deposito é: R$" + conta1.saldo);
            /*

            /*
            Console.WriteLine("nome do usuario " + conta1.nome);
            Console.WriteLine("sua agencia " + conta1.agencia);
            Console.WriteLine("sua conta é " + conta1.conta);
            Console.WriteLine("o saldo da conta é: R$" + conta1.saldo);
            */



        }
    }
}

