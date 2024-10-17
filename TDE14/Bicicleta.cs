public class Bicicleta : Veiculo, IAceleravel
{
    public Bicicleta(string marca, string modelo) : base(marca, modelo)
    {
        
    }

    public void Acelerar()
    {
        Console.WriteLine($"A bicicleta da {Marca} e do modelo {Modelo}, está pedalando mais rápido");
    }

    public override void Ligar()
    {
        Console.WriteLine($"A bicicleta está pronta para uso");
    }
}