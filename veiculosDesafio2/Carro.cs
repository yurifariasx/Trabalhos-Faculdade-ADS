public class Carro : Veiculo
{
    public void Buzinar()
    {
        Console.WriteLine("Carro buzinando");
    }

    public override void Acelerar()
    {
        velocidade = velocidade + 10;
        Console.WriteLine("Carro acelerando");
    }
    public override void Frear()
    {
        velocidade = velocidade - 5;
        Console.WriteLine("Carro acelerando");
    }
}