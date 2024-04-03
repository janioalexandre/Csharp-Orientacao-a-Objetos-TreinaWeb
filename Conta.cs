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
            Console.WriteLine($"Data de Abertura:   { DataAbertura.ToString("dd/MM/yyyy") }");
            Console.WriteLine($"Saldo:              { Saldo.ToString("C") }");
        }

        public void Depositar (decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar (decimal valor)
        {
            Saldo -= valor;
        }
    }
}