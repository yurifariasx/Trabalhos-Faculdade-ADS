public abstract class Veiculo
{
    public int velocidade;

    public abstract void Acelerar();

    public abstract void Frear();

    public void ExibirVelocidade()
    {
        Console.WriteLine("Mostrar Velocidade");
    }


}