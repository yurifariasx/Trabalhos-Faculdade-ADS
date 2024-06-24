using System.Security.Cryptography.X509Certificates;

public class Livro
{
    string Titulo;
    public Autor Autor;

    public double Preco;

    public Livro(string titulo, Autor autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
    public Livro(string titulo, Autor autor,double preco)
    {
        Titulo = titulo;
        Autor = autor;
        Preco = preco;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Titulo do Livro: {Titulo}, Autor do Livro: {Autor.Nome}, Preco do livro: {Preco}");
    }

    public void AplicarDesconto(double ValorDesconto)
    {
        Preco -= Preco * (ValorDesconto / 100);
    }

    public void AplicarDesconto(int ValorDesconto)
    {
        Preco = Preco - ValorDesconto; 
    }

    

}