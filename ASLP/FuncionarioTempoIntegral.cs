public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double SalarioMensal;

    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base (nome, matricula)
    {
        this.SalarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matricula: {Matricula}, Salario: {SalarioMensal}");
        Console.WriteLine("Projetos: ");
        foreach (var projeto in Projetos)
        {
            Console.WriteLine($"- {projeto}");
        }
    }

    public double CalcularBonus()
    {
        return SalarioMensal * 0.10;
    }
}