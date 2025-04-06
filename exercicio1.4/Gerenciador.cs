public class Gerenciador
{
    private readonly IArmazenamento _armazenamento;

    public Gerenciador(IArmazenamento armazenamento)
    {
        _armazenamento = armazenamento;
    }

    public void SalvarArquivo(string nome, byte[] dados)
    {
        Console.WriteLine("Gerenciador esta salvando");
        _armazenamento.Salvar(nome, dados);
    }

    public void ExcluirArquivo(string nome)
    {
        Console.WriteLine("Gerenciador esta Excluindo");
        _armazenamento.Excluir(nome);
    }

    public void CarregarArquivo(string nome)
    {
        Console.WriteLine("Gerenciador esta Carregando");
        _armazenamento.Carregar(nome);
    }

    public void ListarArquivos()
    {
        Console.WriteLine("Gerenciador esta Listando arquivos:");
        var arquivos = _armazenamento.ListarArquivos();
        foreach (var arq in arquivos)
        {
            Console.WriteLine($" - {arq}");
        }
    }
}
