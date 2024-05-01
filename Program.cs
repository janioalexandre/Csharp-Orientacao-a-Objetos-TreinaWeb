using Contas;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            Console.WriteLine(conta.ExibirExtrato());

            var conta2 = new Conta("0001", DateTime.Now, 100);
            Console.WriteLine(conta2.ExibirExtrato());
        }
    }
}