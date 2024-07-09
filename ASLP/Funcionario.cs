public abstract class Funcionario
{
    
    public string Nome;
    public int Matricula;
    //Metodos abstratos
    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();
    
    //Define uma lista para armazenar os projetos
    public List <string> Projetos;
    //Construtor
    public Funcionario(string nome, int matricula)
    {
        this.Nome = nome;
        this.Matricula = matricula;
        Projetos = new List<string>();
    }
    //Sobrecarga de metodos
    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }
    //Metodo para adicionar um projeto
    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }
    

    
    
}