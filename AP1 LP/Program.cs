using System.Formats.Asn1;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

while(true)
{
Console.WriteLine("===|CALCULADORA DE IMC E IDADE|===");

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite seu peso:");
double peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite sua altura:");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

string calcimc;
if(imc < 18.5)
{
    calcimc = "Voçê está abaixo do peso";
}
else if(imc >= 18.5 && imc < 24.9)
{
    calcimc = "Voçê está com o peso normal";
}
else if(imc >= 25 && imc < 29.9)
{
    calcimc = "Voçê está acima do peso";
}
else
{
   calcimc = "Voçê está obeso"; 
}

string faixaEtaria;
    if (idade < 10)
        {
            faixaEtaria = "Criança";
        }
        else if (idade >= 10 && idade < 20)
        {
            faixaEtaria = "Adolescente";
        }
        else if (idade >= 20 && idade < 60)
        {
            faixaEtaria = "Adulto";
        }
        else 
        {
            faixaEtaria = "Idoso";
        }

Console.WriteLine("===| Relatório |===");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade} anos");
Console.WriteLine($"IMC: {imc:F2} ({calcimc})"); 
Console.WriteLine($"Faixa Etária: {faixaEtaria}");


Console.WriteLine("Deseja calcular para outra pessoa? (s/n)");
string resposta = Console.ReadLine();
if (resposta != "s")
{
     break;
}    
}

