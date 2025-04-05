
public class DocumentoPdf:Documento
{
    //atributos especificos
    public string Conteudo { get; set; } 
    public string MarcaDagua { get; private set; } 

    // Construtor
    public DocumentoPdf(string titulo, string autor, DateTime dataCriacao, string conteudo): 
    base(titulo, autor, dataCriacao)
    {
        Conteudo = conteudo;
    }

    //metodo q sera substituido
    public override void Imprimir()
    {

        base.Imprimir(); 
        Console.WriteLine($"Conteudo PDF: {Conteudo}\nMarca d'agua: {MarcaDagua}");
    }

    // Conteudo formatado e marca d'agua
    public override string ConteudoFormatado()
    {
        return $"{Conteudo} \n[Marca d'agua: {MarcaDagua}]";
    }

    // metodo especificos 
    public void AdicionarMarcaDagua(string texto)
    {
        MarcaDagua = texto;
    }
}
