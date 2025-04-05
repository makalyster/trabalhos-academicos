public class Documento
{
    //atributos classe base
    public string Titulo {get;set;}
    public string Autor {get;set;}
    public DateTime DataCriacao {get;set;}

    //Construtor
    public Documento(string titulo, string autor, DateTime dataCriacao)
    {
        Titulo = titulo;
        Autor = autor;
        DataCriacao = dataCriacao ;
    }

    //metodo generico e substituivel
    public virtual void Imprimir()
    {
        Console.WriteLine($"Documento");
        Console.WriteLine($"    Titulo: {Titulo}");
        Console.WriteLine($"    Autor: {Autor}");
        Console.WriteLine($"    Data de Criacao: {DataCriacao}");    
    }

    //metodo generico e substituivel
    public virtual string ConteudoFormatado()
    {
        return $"[Documento Genérico] {Titulo} por {Autor}";
    }
}