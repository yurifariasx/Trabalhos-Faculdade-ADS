class Program
{
    static void Main()
    {
    Autor autor1 = new Autor("Tiririca","Bresil");
    autor1.MostrarInfo();

    Livro Livro1 = new Livro("A morte", autor1, 100.00);
    Livro1.MostrarInfo();
    Livro1.AplicarDesconto(10.00);
    Livro1.MostrarInfo();
    Livro1.AplicarDesconto(10);
    Livro1.MostrarInfo();
    }
    
}



