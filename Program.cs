using System;
using Contas;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();

            conta.Numero = "001";
            conta.DataAbertura = DateTime.Today;
            conta.Saldo = 100;
            
            conta.RealizarEmprestimo(200, 10);
            Console.WriteLine(conta.ExibirExtrato());
        }
    }
}