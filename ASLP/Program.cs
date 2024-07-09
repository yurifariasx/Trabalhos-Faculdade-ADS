using System.Runtime.CompilerServices;

public class Program 
{
    static void Main()
    {
        //Cria uma nova instancia de Empresa
        Empresa empresa = new Empresa();
        //Cria um looping infinito ate que seja digitando um comando especifico
        while (true)
        {//Menu para que o usuario tenha opções de escolha
            Console.WriteLine("|====================-MENU-====================|");
            Console.WriteLine("|1 - Adicionar um funcionario de tempo integral|");
            Console.WriteLine("|2 - Adicionar um funcionario de meio periodo  |");
            Console.WriteLine("|3 - Remover um funcionario                    |");
            Console.WriteLine("|4 - Exibir informações dos funcionarios       |");
            Console.WriteLine("|5 - Adcionar projeto(s) a um funcionario      |");
            Console.WriteLine("|6 - Sair do programa                          |");
        //Armazena o que o usuario digitou seguindo o menu dentro da variavel opcao
             if (int.TryParse(Console.ReadLine(), out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        AdicionarFuncionarioTempoIntegral(empresa);
                        break;
                    case 2:
                        AdicionarFuncionarioMeioPeriodo(empresa);
                        break;
                    case 3:
                        RemoverFuncionario(empresa);
                        break;
                    case 4:
                        empresa.ExibirFuncionarios();
                        break;
                    case 5:
                        AdicionarProjeto(empresa);
                        break;
                    case 6:
                        Console.WriteLine("|Programa Encerrado|");
                        return;
                    default:
                        Console.WriteLine("|Opção inválida. Tente novamente.|");
                        break;
                }
            }
            else
            {
                Console.WriteLine("|ERRO Tente novamente.|");
            }
        }
    }

    static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {//Coleta o nome digitado e armazena na variavel "nome" com o ReadLine 
        Console.Write("|Nome:|");
        string nome = Console.ReadLine();

        Console.Write("|Matrícula:|");
        int matricula = int.Parse(Console.ReadLine());
        
        Console.Write("|Salário Mensal:|");
        double salarioMensal = double.Parse(Console.ReadLine());
    //Cria uma nova instancia de FuncionarioTempoIntegral/Adiciona um novo funcionario
        FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
        empresa.AdicionarFuncionario(funcionario);
        Console.WriteLine("|Funcionário Tempo Integral adicionado com sucesso.|");

    }

    static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Salário por Hora: ");
        double salarioPorHora = double.Parse(Console.ReadLine());
        Console.Write("Horas Trabalhadas: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
        empresa.AdicionarFuncionario(funcionario);
        Console.WriteLine("|Funcionário Meio Período adicionado com sucesso.|");       
    }
         static void RemoverFuncionario(Empresa empresa)
    {
        Console.Write("|Matrícula do Funcionário a ser removido: |");
        int matricula = int.Parse(Console.ReadLine());
        empresa.RemoverFuncionario(matricula);
    } 

    static void AdicionarProjeto(Empresa empresa)
    {
        Console.Write("|Matrícula do Funcionário: |");
        int matricula = int.Parse(Console.ReadLine());
        //Busca um funcionario na lista da empresa com base na matricula
        var funcionario = empresa.funcionarios.FirstOrDefault(f => f.Matricula == matricula);
                                            //Biblioteca LINQ
        if (funcionario != null)
        {
            Console.Write("Quantos projetos deseja adicionar? ");
            int quantidade = int.Parse(Console.ReadLine());
//solicita ao usuário o nome de cada projeto e adiciona os nomes dos projetos à lista de projetos
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Nome do Projeto {i + 1}: ");
                string projeto = Console.ReadLine();
                funcionario.AdicionarProjeto(projeto);
            }
        }
        else
        {
            Console.WriteLine($"Funcionário com matrícula {matricula} não encontrado.");
        }
    }
}

        

    
