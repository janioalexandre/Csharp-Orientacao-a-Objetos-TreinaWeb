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

        public void RealizarEmprestimo(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"O valor { valor } foi creditado e será debitado dentro de 30 dias.");
        }

        public void RealizarEmprestimo(decimal valor, int parcelas)
        {
            Saldo += valor;
            Console.WriteLine($"O valor { valor } foi creditado e será debitado em { parcelas } vezes.");
        }
    }
}