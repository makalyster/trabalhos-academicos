Console.Clear();

Console.WriteLine("TITULO");
string Titulox = Console.ReadLine();
Console.WriteLine("AUTOR");
string Autorx = Console.ReadLine();
Console.WriteLine("CONTEUDO");
string Conteudox = Console.ReadLine();

DateTime Datax = DateTime.Now;

/*
string Titulox = "abc";
string Autorx = "abc";
DateTime Datax = DateTime.Now;
string Conteudox = "abc";
*/

Console.Clear();

Documento Documento1 = new Documento(Titulox,Autorx,Datax,Conteudox);
Documento1.Imprimir();
Console.WriteLine("");
Console.WriteLine("Conteudo:");
Console.WriteLine($"    {Documento1.ConteudoFormatado()}");
