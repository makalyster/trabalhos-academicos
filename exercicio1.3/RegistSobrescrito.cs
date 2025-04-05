class RegistroSobrescrito : RegistroBase
{
    public override void Salvar()
    {
        Console.WriteLine("salvando sobrescrito");
    }
}
