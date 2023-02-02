using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ContaCorrente
{
    public string nome;
    public int agencia;
    public string conta;
    public double saldo, valorTrasferencia;

    


    public bool Sacar(double valor)
    {

        if (this.saldo >= valor)
        {


            this.saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("saldo insuficiente para realizar o saque. ");
            return false;

        }





    }

        public bool Transferir(double valor,ContaCorrente contaDestino)
    {
        if(this.saldo >= valor)
        {
            valorTrasferencia = valor;
            this.saldo -= valor;
            contaDestino.saldo = valor;
            return true;

        }
         else
        {
            Console.WriteLine("não foi possivel realizar a trasferencia o saldo é insuficiente");
            return false;
        }

    }    
        

     

    




}









    

     
