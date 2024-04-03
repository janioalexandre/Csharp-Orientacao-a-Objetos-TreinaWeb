﻿using System;
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
            conta.Saldo = 0;

            conta.ExibirExtrato();
            conta.Depositar(50);
            conta.ExibirExtrato();
            conta.Sacar(30);
            conta.ExibirExtrato();
        }
    }
}