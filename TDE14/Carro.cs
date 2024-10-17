using System.Security.Cryptography.X509Certificates;

public class Carro : Veiculo, IAceleravel, IFreavel
{
    public Carro(string marca, string modelo) : base(marca, modelo)
    {

    }

    public override void Ligar()
    {
        Console.WriteLine($"O veiculo de marca {Marca} e modelo {Modelo} está ligando.");
    }

    public void Acelerar()
    {
        Console.WriteLine($"O carro de modelo {Modelo} e marca {Marca} está acelerando");
    }

    public void Frear()
    {
        Console.WriteLine($"O carro de modelo {Modelo} e marca {Marca} está freando");
    }
}