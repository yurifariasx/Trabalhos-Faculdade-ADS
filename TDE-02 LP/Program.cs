// 1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
using System.Net.Mail;

class TDE{ 
  static void Main(){

string nome = "Paulo";
int idade = 17;
double nota = 7.5;

//Concatenação
Console.WriteLine(" Aluno " + nome + " tem " + idade + " anos e" + " nota " + nota);
//interpolação
Console.WriteLine($" Aluno {nome} tem {idade} anos e nota {nota}");

// 2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

//Concatenação
Console.WriteLine(" Aluno: " + nome + "\n tem: " + idade + " anos e" + "\n nota: " + nota);
//interpolação
Console.WriteLine($" Aluno: {nome} \n tem: {idade} anos e \n nota: {nota}");

// 3 - Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (X) double
// ( ) long
// ( ) decimal 

// 4 - Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (x) double para long
// ( ) double para float
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal

// 5 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings

Console.WriteLine("Digite 3 letras:");

Console.Write("Digite a primeira letra: ");
char letra1 = Convert.ToChar(Console.ReadLine());

Console.Write("Digite a Segunda letra: ");
char letra2 = Convert.ToChar(Console.ReadLine());

Console.Write("Digite a Terceira letra: ");
char letra3 = Convert.ToChar(Console.ReadLine());

//Exibindo resultado invertido em concatenação
Console.WriteLine(" " + letra3 + " " + letra2 + " " + letra1);
//Exibindo resultado invertido em interpolação
Console.WriteLine($" {letra3} {letra2} {letra1}");

// 6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical

// 7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:

Console.WriteLine("Digite 2 numeros:");

Console.Write("Digite o primeiro numero: ");
double numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo numero: ");
double numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Soma de {numero1} + {numero2}: {numero1 + numero2}");
Console.WriteLine($"Subtração de {numero1} - {numero2}: {numero1 - numero2}");
Console.WriteLine($"Multiplicação de {numero1} * {numero2}: {numero1 * numero2}");
Console.WriteLine($"Potencia de {numero1} elevado ao {numero2}: {Math.Pow(numero1, numero2)}");
Console.WriteLine($"Raiz quadrada de {numero1}: {Math.Sqrt(numero1)}");
Console.WriteLine($"Raiz quadrada de {numero2}: {Math.Sqrt(numero2)}");
double divisao = (double) numero1 / numero2;
Console.WriteLine($"Divisão de {numero1} / {numero2}: {divisao}");
Console.WriteLine($"Resto de Divisão de {numero1} % {numero2}: {Math.Max(numero1, numero2)}");

// 8 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)

Console.WriteLine("Digite seu usuario: ");
string nome1 = Console.ReadLine();
Console.WriteLine("Digite sua senha: ");
string senhastring = Console.ReadLine();
int senha = Convert.ToInt32(senhastring);

string mensagem = nome1 == "admin" || nome1 == "Maria" && senha == 123 ?
  "Login feito com Sucesso" : "Login invalido";

Console.WriteLine(mensagem);

// 9 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Digite o primeiro número inteiro (x):");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número inteiro (y):");
int y = int.Parse(Console.ReadLine());

string resultadoX = x % 2 == 0 ? "par" : "ímpar";
string resultadoY = y % 2 == 0 ? "par" : "ímpar";

Console.WriteLine($"x é {resultadoX}.");
Console.WriteLine($"y é {resultadoY}.");




  
}


  }

