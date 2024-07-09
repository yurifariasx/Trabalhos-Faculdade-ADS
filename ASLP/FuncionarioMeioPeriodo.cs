public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double SalarioPorHora;

    private double NumeroHorasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, double numeroHorasTrabalhadas) : base (nome, matricula)
    {
        this.SalarioPorHora = salarioPorHora;
        this.NumeroHorasTrabalhadas = numeroHorasTrabalhadas;
    }
    public override double CalcularSalario()
    {
        return SalarioPorHora * NumeroHorasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matricula: {Matricula}, Salario por hora: {SalarioPorHora}, Numero de horas trabalhadas: {NumeroHorasTrabalhadas}");
        foreach (var projeto in Projetos)
        {
            Console.WriteLine($"- {projeto}");
        }
    }

     public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }
}