using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("== Armazenamento Local ==");
        var local = new ArmazenamentoLocal();
        var gerenciadorLocal = new Gerenciador(local);
        gerenciadorLocal.SalvarArquivo("local.txt", new byte[] { 1, 2, 3 });
        gerenciadorLocal.ListarArquivos();
        gerenciadorLocal.CarregarArquivo("local.txt");
        gerenciadorLocal.ExcluirArquivo("local.txt");

        Console.WriteLine("\n== Armazenamento Nuvem ==");
        var nuvem = new ArmazenamentoNuvem();
        var gerenciadorNuvem = new Gerenciador(nuvem);
        gerenciadorNuvem.SalvarArquivo("nuvem.txt", new byte[] { 9, 8, 7 });
        gerenciadorNuvem.ListarArquivos();
        gerenciadorNuvem.CarregarArquivo("nuvem.txt");
        gerenciadorNuvem.ExcluirArquivo("nuvem.txt");

        Console.WriteLine("\n== Histórico de Operações (Nuvem) ==");
        if (nuvem is IRastreavel rastreavel)
        {
            var historico = rastreavel.ObterHistoricoOperacoes();
            foreach (var item in historico)
                Console.WriteLine(item);
        }
    }
}
