public class GerenciadorDocumentos
{
    public void ProcessarColecao(List<Documento> documentos)
    {
        foreach (var doc in documentos)
        {
            doc.Imprimir();
            Console.WriteLine("Conteúdo Formatado:");
            Console.WriteLine(doc.ConteudoFormatado());
            
            Console.WriteLine(new string('-', 30));
        }
    }
}
