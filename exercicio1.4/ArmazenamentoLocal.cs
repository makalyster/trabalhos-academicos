public class ArmazenamentoLocal : IArmazenamento
{
    private List<string> arquivos = new();

    public bool Salvar(string nome, byte[] dados)
    {
        Console.WriteLine($"[Local] Salvando arquivo: {nome} ({dados.Length} bytes)");
        if (!arquivos.Contains(nome))
            arquivos.Add(nome);
        return true;
    }

    public byte[] Carregar(string nome)
    {
        Console.WriteLine($"[Local] Carregando arquivo: {nome}");

        if (arquivos.Contains(nome))
        {
            return new byte[] { 0x00 };
        }
        else
        {
            return null;
        }
    }


    public bool Excluir(string nome)
    {
        Console.WriteLine($"[Local] Excluindo arquivo: {nome}");
        return arquivos.Remove(nome);
    }

    public List<string> ListarArquivos()
    {
        Console.WriteLine("[Local] Listando arquivos");
        return new List<string>(arquivos);
    }
}
