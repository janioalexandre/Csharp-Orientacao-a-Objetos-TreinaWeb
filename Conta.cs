using System;

namespace Contas
{
    public class Conta
    {
        public string Numero;
        public DateTime DataAbertura;
        public decimal Saldo;

        public string ExibirExtrato()
        {
            return  $"Conta N:            { Numero }{ Environment.NewLine }" + 
                    $"Data de Abertura:   { DataAbertura.ToString("dd/MM/yyyy") }{ Environment.NewLine }" +
                    $"Saldo:              { Saldo.ToString("C") }{ Environment.NewLine }" +
                    "-------------------------------";
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