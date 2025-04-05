
public class DocumentoHtml:Documento
{
    public string Html { get; set; } // conteudo do HTML

    // Construtor
    public DocumentoHtml(string titulo, string autor, DateTime dataCriacao, string html): 
    base(titulo, autor, dataCriacao)
    {
        Html = html;
    }

    public override void Imprimir()
    {
        base.Imprimir(); 
        Console.WriteLine($"HTML:\n{Html}"); 
    }
    
    public override string ConteudoFormatado()
    {
        return $"<html><body>{Html}</body></html>";
    }
}
