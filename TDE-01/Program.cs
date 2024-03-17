using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class TDE{ 
  static void Main(){
//1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
byte idade = 35;
Console.WriteLine(idade);
//2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);
//3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.
decimal altura = 3.45m;
Console.WriteLine(altura);
//4 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
const int ano = 12;
Console.WriteLine(ano);
//5 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
double? nota = 7.80;
Console.WriteLine(nota);
//6 - Quais as diferenças entre os tipos por valor e os tipos por referência ?
// Resposta = Um tipo de valor mantém os dados dentro de sua própria alocação de memória e um tipo de referência contém um ponteiro para outro local da memória que mantém os dados reais. As variáveis ​​de tipo de referência são armazenadas na heap, enquanto as variáveis ​​de tipo de valor são armazenadas na stack. A stack é usada para alocação de memória estática e heap para alocação de memória dinâmica, ambas armazenadas na RAM do computador.

//7 - O que é um nullable type e qual a sua utilidade ?
//Resposta = Nullable Types é um recurso do C# que nos permite atribuir o valor null a um tipo de dado que, por padrão, não aceita valores nulos: os tipos primitivos. Esse recurso é útil quando precisamos realizar operações em banco de dados e desejamos armazenar um valor nulo em um campo que, posteriormente, receberá um valor de tipo primitivo, como int, float, bool, etc.

//8 - O que é Camel Case ? Dê um exemplo de sua aplicação.
//Resposta: Camel case é um estilo de nomenclatura de texto usado em programação que combina várias palavras em uma única palavra, em que a primeira letra de cada palavra é escrita em minúscula, exceto a primeira palavra. Por exemplo, se quisermos nomear uma variável que represente a idade de uma pessoa, podemos chamá-la de "idadeDaPessoa" em camel case.

//9 - O que é Pascal Case ? Dê um exemplo de sua aplicação: combina várias palavras em uma única palavra, mas a primeira letra de cada palavra é escrita em maiúscula. Por exemplo, se quisermos nomear uma classe que representa um carro, podemos chamá-la de "Carro" em Pascal case.

//10.1 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma)
int x = 77;
int y = 66;
Console.WriteLine(x + y);
//10.2 outra forma de fazer.
int soma = x + y;
Console.WriteLine(soma);
//11 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
//Resposta: 
//  char = O valor padrão do tipo char é \0, ou seja, U+0000.
//  bool = O valor padrão do tipo bool é false.
//  int, double, float e decimal = O valor padrão é 0.
//  string = O valor padrão de uma string é null.
 }
};


