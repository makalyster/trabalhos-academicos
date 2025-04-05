

public class DocumentoTexto:Documento
{
    //atributos especifico
    public string Conteudo { get; set; }
    
    // Construtor DocTxt e Construtor herdado
    public DocumentoTexto(string titulo, string autor, DateTime dataCriacao, string conteudo): 
    base(titulo, autor, dataCriacao)
    {
        Conteudo = conteudo;
    }

    //metodo q sera substituido
    public override void Imprimir()
    {
        base.Imprimir(); 
        Console.WriteLine($"Conteúdo: {Conteudo}"); 
    
    }

    //conteudo do txt
    public override string ConteudoFormatado()
    {
        return Conteudo;
    }

    //metodo especifico
    public int ContarPalavras()
    {
        int contador = 0;
        bool dentroDaPalavra = false;

        //verifica letra a letra a divisao das palavras
        for (int i = 0; i < Conteudo.Length; i++)
        {
            if (Conteudo[i] != ' ' && !dentroDaPalavra)
            {
                dentroDaPalavra = true;
                contador++;
            }
            else if (Conteudo[i] == ' ')
            {
                dentroDaPalavra = false;
            }
        }

        return contador;
    }

}
