//Exercício 1

float cm;
float m;
float mm;


Console.WriteLine("Digite a quantidade em metros que quer converter: ");
m = float.Parse(Console.ReadLine());

cm = (m * 100);
Console.WriteLine("Sua medida em metros fica, em centímetros {0}cm", cm);
mm = (1000 * m);
Console.WriteLine("Já em milímetros fica {0} mm", mm);



//Exercício 2

float f;
float c;
int fa;
int ce;
float op;
Console.WriteLine("Você quer converter em números inteiros ou decimais?");
Console.WriteLine("Digite 1 para decimais ou 2 para inteiros: ");
op = float.Parse(Console.ReadLine());
if (op == 1)
{
    Console.WriteLine("Quantos graus em Fahrenheit está fazendo? ");
    f = float.Parse(Console.ReadLine());
    c = ((f - 32.0f) * (5.0f / 9.0f));
    Console.WriteLine("Está fazendo {0} em graus celsius", c);
}
if (op == 2)
{
    Console.WriteLine("Quantos graus em Fahrenheit está fazendo?(inteiro) ");
    fa = int.Parse(Console.ReadLine());
    ce = ((fa - 32) * (5 / 9));
    Console.WriteLine("Está fazendo {0} em graus celsius", ce);
}

//A conversão em números inteiros da 0 por causa que convertendo um valor decimal em inteiro, o sistema tende a contar só as casas inteiras

//Exercicío 3

float alt;
float peso;
float imc;

Console.WriteLine("Qual é a sua altura em metros?");
alt = float.Parse(Console.ReadLine());
Console.WriteLine("Qual é o seu peso em quilogramas?");
peso = float.Parse(Console.ReadLine());
imc = peso / (alt * alt);
Console.WriteLine("O seu IMC é de {0}", imc);
Console.WriteLine(imc);


//Exercicío 4

float nu1;
float nu2;
float nu3;
float nu4;

Console.WriteLine("Digite o valor do primeiro número: ");
nu1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do segundo número: ");
nu2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do terceiro número: ");
nu3 = float.Parse(Console.ReadLine());

nu4 = (nu1 + nu2 + nu3) / 3;


Console.WriteLine("A média ponderada é igual a {0}", nu4);

//Exercicío 5
//essa fórmula é para calcular o tempo que vai levar para cruzar um intervalo, usando de base a velocidade e a distância
float distancia;
float velocidade;
float tempo;
float opc;
float min;

Console.WriteLine("Qual a velocidade que você percorre em quilometros por hora(km/h)?");
velocidade = float.Parse(Console.ReadLine());
Console.WriteLine("Qual a distância que você vai percorrer?");
distancia = float.Parse(Console.ReadLine());

tempo = distancia / velocidade;

Console.WriteLine("O tempo que você vai levar é de {0} horas", tempo);
Console.WriteLine("Se quiser fazer a conversão para minutos, digite 1, se não, digite qualquer número além do 1");
opc = float.Parse(Console.ReadLine());
if (opc == 1)
{
    min = tempo * 60;
    Console.WriteLine("O tempo que você vai levar é de {0} minutos", min);

}



//Exercício 6
float sal;
float newsal;
float d1;


Console.WriteLine("Qual o seu sálario atual?");
sal = float.Parse(Console.ReadLine());

d1 = sal / 100 * 25;

newsal = sal + d1;
Console.WriteLine("seu novo sálario agora é de {0} reais", newsal);


//exercicío 7
float dolar;
float valor;
float real;


dolar = 4.94f;
Console.WriteLine("Qual o valor em real que você quer converter em dólares?");
valor = float.Parse(Console.ReadLine());
real = valor / dolar;

Console.WriteLine("O seu valor de {0} em reais brasileiros é {1} em dólar", valor, real);



//exercício 8
int n1;
int n2;

Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());
n2 = (n1 * 3 + 1) + (n1 * 2 - 1);

Console.WriteLine(n2);

//Exercicío 9
Console.WriteLine("Digite um número inteiro de 4 dígitos:"); 
int numero = int.Parse(Console.ReadLine());
if (numero < 1000 || numero > 9999)
{ Console.WriteLine("O número digitado não possui 4 dígitos."); }
else
{
    int digito1 = numero / 1000;
    int digito2 = (numero % 1000) / 100;
    int digito3 = (numero % 100) / 10;
    int digito4 = numero % 10;
    Console.WriteLine(digito1);
    Console.WriteLine(digito2);
    Console.WriteLine(digito3);
    Console.WriteLine(digito4);
}
