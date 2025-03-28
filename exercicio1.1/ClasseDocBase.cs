public class Documento
{
    public string Titulo;
    public string Autor;
    public DateTime DataCriacao;
    public string Conteudo; // ?

    public Documento(string titulo, string autor, DateTime dataCriacao , string conteudo = null)
    {
        Titulo = titulo;
        Autor = autor;
        DataCriacao = dataCriacao ;
        Conteudo = conteudo;
    }

    public virtual void Imprimir()
    {
        Console.WriteLine($"Documento");
        Console.WriteLine($"    Titulo: {Titulo}");
        Console.WriteLine($"    Autor: {Autor}");
        Console.WriteLine($"    Data de Criacao: {DataCriacao}");
    }

    public virtual string ConteudoFormatado()
    {
        return Conteudo;
    }
}