using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = "Malakias";
            conta.Agencia = 863;
            conta.Numero = 145236;
            conta.Saldo = 500.00;

            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Saldo);

            conta.Saldo += 200;

            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}

