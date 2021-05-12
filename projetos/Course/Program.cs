using System;
using System.Globalization;

namespace Course
{
    class Program{
        static void Main(string[] args){
            sbyte x = 127;
            int y = 86;
            string z = "23";
            int k = 2147483647;
            long w = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float flutuante = 4.5f;
            double duplo = 4.5;
            double saldo = 100357.844565;
            string nome = "Pier Bottero";
            object obj1 = "Valor string de obj1";
            object bjj2 = 4.6;
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            long maxLong = long.MaxValue;
            decimal maxDecimal = decimal.MaxValue;

            Console.WriteLine("Valor minimo de var tipo int: "+minInt);
            Console.WriteLine("Valor maximo de var tipo int: "+maxInt);
            Console.WriteLine("Valor minimo de var tipo sbyte: "+minSbyte);
            Console.WriteLine("Valor máximo de var tipo long: "+maxLong);
            Console.WriteLine("Valor máximo de var tipo decimal: " + maxDecimal);


            Console.WriteLine(z + x + y);
            Console.WriteLine(x + y + z);
            Console.WriteLine(x);
            x++;
            Console.WriteLine(x);
            Console.WriteLine(k);
            Console.WriteLine(w);
            Console.WriteLine("Boolean "+completo);
            Console.WriteLine("Char Genero "+genero + " decladado com aspas simples");
            Console.WriteLine("Letra (com cod UTF) "+letra + " decladado com aspas simples");
            Console.WriteLine("Numero Float (valor declarado com f no final) "+flutuante);
            Console.WriteLine("Numero Double (não precisa do f no final "+duplo);
            Console.WriteLine("String "+nome+" declarado com aspas duplas");
            Console.WriteLine("Um valor string tem seu conteudo imutavel, mas pode se atribuir uma outra string a variável");
            nome = "Emerson Bottero";
            Console.WriteLine("Variavel nome que recebou outro valor "+nome);
            Console.WriteLine("Conteudo de variavel generica tipo object: "+obj1);
            Console.WriteLine("Conteudo de variavel genérica tipo object: "+bjj2);
            Console.WriteLine("Texto de comando Console.WriteLine, onde a linha é quebrada");
            Console.Write("Texto de comando Console.Write, sem quebra de linha - ");
            Console.Write("Mais um texto de comando Console.Write, na mesma linha do comando anterior");
            Console.WriteLine("");
            Console.WriteLine("================================");
            Console.WriteLine("Variavle tipo double: "+saldo);
            Console.WriteLine("Variavle tipo double com duas casas decimais: " + saldo.ToString("F2"));
            Console.WriteLine("Variavle tipo double com quatro casas decimais: " + saldo.ToString("F4"));
            Console.WriteLine("Usando . como separador, eliminando config locais: " + saldo.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("==============USANDO PLACEHOLDERS==========");
            Console.WriteLine("{0} tem {1} de idade e possui saldo de R$ {2:F2} em conta.", nome, z, saldo);
            Console.WriteLine("==============USANDO INTERPOLAÇÃO==========");
            Console.WriteLine($"{nome} tem {z} de idade e possui saldo de R$ {saldo:F2} em conta.");
            Console.WriteLine("==============USANDO CONCATENAÇÃO==========");
            Console.WriteLine(nome+" tem " +z+" de idade e possui saldo de R$ "+saldo.ToString("f2")+" em conta.");

            Console.WriteLine("=================OPERADORES DE ATRIBUIÇÃO==============");
            int a = 10;
            Console.WriteLine($"Variavle a vale 10: {a}");
            a += 2;
            Console.WriteLine($"Variavel a acrescido de 2 com operador +=: {a}");
            a *= 3;
            Console.WriteLine($"Variavel a que já tinha acrescido o valor 2 com += agora é multiplicada por 3 copm operador *=: {a}");
            string str1 = "ABC";
            Console.WriteLine($"str1: {str1}");
            string str2 = "DEF";
            Console.WriteLine($"str2: {str2}");
            Console.WriteLine($"str1 concatenada com str2 usando operador += {str1+=str2}");
            Console.WriteLine("Operadores aritméticos de atribuição");
            int x1 = 10;
            Console.WriteLine($"Variavel x1 {x1}");
            x1++;
            Console.WriteLine($"Variavel x1 acrescida de 1 usando operador ++ {x1}");
            x1--;
            Console.WriteLine($"Se uma var x1 = 10 e eu crio uma variavel int x2 e atribui a essa variavel x1++,");
            Console.WriteLine($"a variavel x2 vai valer 10, pois primeiro eu atribui a ela o valor de x1 e depois eu acresci o valor");
            int x2 = x1++;
            Console.WriteLine($"Valor de variavel x2 recebendo x1++ {x2}");
            Console.WriteLine($"Agora uma variavel x3 que recebe o valor ++x1,");
            Console.WriteLine($"vai valer 11, pois primeiro o valor de x1 e´acrescido e depois atribuido a x3");
            x1--;
            int x3 = ++x1;
            Console.WriteLine($"Valor de variavel x3 recebendo ++x1 {x3}");
            Console.WriteLine("");
            Console.WriteLine("=================CONVERSÃSO IMPLICITA DE VALORES==============");
            Console.WriteLine("");
            float xfl = 4.5f;
            Console.WriteLine($"Variavel float xfl = {xfl}");
            Console.WriteLine("Podemos criar uma var tipo double (que suporta 8 bytes) recebendo");
            Console.WriteLine("o valro de xfl que é do tipo float (suporte de 4 bytes)");
            double xdb = xfl;
            Console.WriteLine($"Variavel double xdb recebendo valor de xfl {xdb}");
            Console.WriteLine("");
            Console.WriteLine("Para o contrario, seria necessário fazer um casting do valor");
            Console.WriteLine("estando ciente da possibilidade de perda de dados em função da limitação de bytes suportada");
            Console.WriteLine("pelo tipo de variavel");
            double ydb = 5.1;
            Console.WriteLine($"Variavel double ydb = {ydb}");
            float yfl = (float)ydb;
            Console.WriteLine($"Variavel float yfl recebe valro de variavel double ydb por casting;");
            Console.WriteLine($"float yfl = (float)ydb");
            Console.WriteLine($"yfl = {yfl}");
            Console.WriteLine($"Uma variavel do tipo double sendo atribuida a uma");
            Console.WriteLine($"variavel de tipo int perde balores. Os valores ficarão truncados");
            double adb = 5.1;
            Console.WriteLine($"double adb = 5.1");
            int bin = (int)adb;
            Console.WriteLine($"Variavel int bin = (int)adb = {bin}");
            Console.WriteLine($"Valor foi arredondado no casting");
            Console.WriteLine($"");
            Console.WriteLine($"Variavies tipo double que recebem valores de operações aritmeticas com valores de tipo int");
            Console.WriteLine($"precisam ser atribuidas via casting.");
            Console.WriteLine($"Exemplo:");
            int aint = 5;
            int bint = 2;
            double resultadoSemCasting = aint / bint;
            Console.WriteLine($"int aint = 5 / int bint = 2");
            Console.WriteLine($"aint / bint = {resultadoSemCasting}");
            double resultadoComCasting = (double) aint / bint;
            Console.WriteLine($"(double) aint / bint = {resultadoComCasting}");
            Console.WriteLine("");
            Console.WriteLine("=================Operadores aritméticos==============");
            Console.WriteLine("");
            int n1 = 3 + 4 * 2;
            Console.WriteLine($"int n1 = 3 + 4 * 2 | n1 = {n1}");
            int n2 = (3 + 4) * 2;
            Console.WriteLine($"int n1 = (3 + 4) * 2 | n2 = {n2}");
            int n3 = 17 % 3;
            Console.WriteLine($"int n3 = 17 % 3 | n3 = {n3}");
            int n4 = 10 / 8;
            Console.WriteLine($"int n4 = 10 / 8 | n4 = {n4}");
            double n5 = 10 / 8;
            Console.WriteLine($"double n5 = 10 / 8 | n5 = {n5}");
            double n6 = (double) 10 / 8;
            Console.WriteLine($"double n6 = (double) 10 / 8 | n6 = {n6}");
            double n7 = 10.0 / 8.0;
            Console.WriteLine($"double n7 = 10.0 / 8; | n7 = {n7}");


            Console.WriteLine($"");
            Console.WriteLine($"=====Equação de 2º grau (Formula de Baskara)=====");

            double a1 = 1.0, b1 = -3.0, c1 = -4.0;
            Console.WriteLine($"double a1 = 1.0, b1 = -3.0, c1 = -4.0;");

            double delta = Math.Pow(b1, 2.0) - 4.0 * a1 * c1;
            Console.WriteLine($"double delta = Math.Pow(b1, 2.0) - 4.0 * a1 * c1 | delta = {delta}");

            double bsk = (-b1 + Math.Sqrt(delta)) / (2.0 * a1);
            Console.WriteLine($"double bsk = (-b1 + Math.Sqrt(delta)) / (2.0 * a1) | bsk = {bsk}");




            Console.WriteLine($"");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");




        }
    }
}
