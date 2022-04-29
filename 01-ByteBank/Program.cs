using _01_ByteBank.Models;
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
            ContaCorrente contaGabriela = new ContaCorrente
            {
                Titular = "Gabriela",
                Agencia = 863,
                Numero = 8635654,
                Saldo = 100
            };
        }
    }
}
