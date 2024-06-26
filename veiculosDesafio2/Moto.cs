public class Moto : Veiculo
{
    public override void Acelerar()
    {
        velocidade = velocidade + 15;
        Console.WriteLine("Moto acelerando");
    }
    public override void Frear()
    {
        velocidade = velocidade - 10;
        Console.WriteLine("Carro acelerando");
    }
}