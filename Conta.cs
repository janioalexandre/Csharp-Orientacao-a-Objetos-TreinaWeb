using System;

namespace Contas
{
    public class Conta
    {
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        public void ExibirExtrato()
        {
            Console.WriteLine($"Conta N:            { Numero }");
            Console.WriteLine($"Data de Abertura:   { DataAbertura }");
            Console.WriteLine($"Saldo:              { Saldo }");
        }
    }
}