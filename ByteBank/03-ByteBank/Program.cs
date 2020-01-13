using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGrabielaCosta = new ContaCorrente();
            contaGrabielaCosta.Titular = "Gabriela";
            contaGrabielaCosta.Agencia = 863;
            contaGrabielaCosta.Numero = 863452;

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.Titular = "Gabriela";
            contaGabriela.Agencia = 863;
            contaGabriela.Numero = 863452;

            Console.WriteLine("Igualdade de tipo de valor: " + (contaGabriela == contaGrabielaCosta));

            contaGabriela = contaGrabielaCosta;

            Console.WriteLine("Igualdade de tipo de valor: " + (contaGabriela == contaGrabielaCosta));

            Console.ReadLine();
        }
    }
}
