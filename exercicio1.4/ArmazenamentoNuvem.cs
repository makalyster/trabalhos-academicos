public class ArmazenamentoNuvem : IArmazenamento, IRastreavel
{
    private List<string> arquivos = new();
    private List<string> historico = new();

    public bool Salvar(string nome, byte[] dados)
    {
        Console.WriteLine($"[Nuvem] Salvando arquivo: {nome} ({dados.Length} bytes)");
        if (!arquivos.Contains(nome))
            arquivos.Add(nome);

        RegistrarOperacao("Salvar", nome);
        return true;
    }

    public byte[] Carregar(string nome)
    {
        Console.WriteLine($"[Nuvem] Carregando arquivo: {nome}");
        RegistrarOperacao("Carregar", nome);
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
        Console.WriteLine($"[Nuvem] Excluindo arquivo: {nome}");
        RegistrarOperacao("Excluir", nome);
        return arquivos.Remove(nome);
    }

    public List<string> ListarArquivos()
    {
        Console.WriteLine("[Nuvem] Listando arquivos...");
        return new List<string>(arquivos);
    }

    public void RegistrarOperacao(string operacao, string arquivo)
    {
        historico.Add($"{operacao} -> {arquivo}");
    }

    public List<string> ObterHistoricoOperacoes()
    {
        return new List<string>(historico);
    }
}
