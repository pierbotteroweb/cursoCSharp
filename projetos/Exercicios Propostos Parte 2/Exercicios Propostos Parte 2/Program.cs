using System;
using System.Globalization;

namespace Exercicios_Propostos_Parte_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercícios propostos Parte 2");
            Console.WriteLine();
            Console.WriteLine("Exercicio 1");
            Console.WriteLine();
            Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.");
            Console.WriteLine("");
            Console.Write("Informe um número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());
            if (numero1 >= 0) {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else {
                Console.WriteLine("NEGATIVO");
            }
            Console.WriteLine();
            Console.WriteLine("Exercicio 2");
            Console.WriteLine();
            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
            Console.WriteLine("");
            Console.Write("Informe um número inteiro: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero2 % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
            Console.WriteLine();
            Console.WriteLine("Exercicio 3");
            Console.WriteLine();
            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 'Sao Multiplos' ou 'Nao sao");
            Console.WriteLine("Multiplos', indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em");
            Console.WriteLine("ordem crescente ou decrescente.");
            Console.WriteLine("");
            Console.Write("Informe os números: ");
            string[] numeros = Console.ReadLine().Split(" ");
            int numero3 = int.Parse(numeros[0]);
            int numero4 = int.Parse(numeros[1]);
            if (numero3 % numero4 == 0 || numero4 % numero3 == 0) {
                Console.WriteLine("São Múltiplos");
            }
            else {
                Console.WriteLine("Não são Múltiplos");
            }
            Console.WriteLine();
            Console.WriteLine("Exercicio 4");
            Console.WriteLine();
            Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,");
            Console.WriteLine("sabendo que o mesmo pode começar em um dia e terminar em outro,");
            Console.WriteLine("tendo uma duração mínima de 1 hora e máxima de 24 horas.");
            Console.WriteLine("");
            Console.Write("Informe as horas de inicio e final do jogo: ");
            string[] horas = Console.ReadLine().Split(" ");
            int inicio = int.Parse(horas[0]);
            int final = int.Parse(horas[1]);
            int duracao = 0;
            if (inicio > final) {
                duracao = 24 - inicio + final;
            }
            else {
                duracao = final - inicio;
            }
            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            Console.WriteLine();
            Console.WriteLine("Exercicio 5");
            Console.WriteLine();
            Console.WriteLine("Com base na tabela abaixo, escreva um programa que leia o");
            Console.WriteLine("código de um item e a quantidade deste item. A seguir,");
            Console.WriteLine("calcule e mostre o valor da conta a pagar.");
            Console.WriteLine("===================================");
            Console.WriteLine("CÓDIGO    ESPECIFICAÇÃO     PREÇO  ");
            Console.WriteLine("===================================");
            Console.WriteLine("1         Cachorro Quente   R$ 4.00");
            Console.WriteLine("2         X-Salada          R$ 4.50");
            Console.WriteLine("3         X-Bacon           R$ 5.00");
            Console.WriteLine("4         Torrada simples   R$ 2.00");
            Console.WriteLine("5         Refrigerante      R$ 1.50");
            Console.WriteLine("===================================");
            Console.WriteLine();
            double cod1 = 4.0;
            double cod2 = 4.5;
            double cod3 = 5.0;
            double cod4 = 2.0;
            double cod5 = 1.5;
            Console.Write("Informe o código do lanche e a quantidade: ");
            string[] lanche = Console.ReadLine().Split(" ");
            int codLanche = int.Parse(lanche[0]);
            int qtdLanche = int.Parse(lanche[1]);
            double valorTotal = 0;
            if (codLanche == 1) {
                valorTotal = qtdLanche * cod1;
            }
            else if (codLanche == 2) {
                valorTotal = qtdLanche * cod2;
            }
            else if (codLanche == 3) {
                valorTotal = qtdLanche * cod3;
            }
            else if (codLanche == 4) {
                valorTotal = qtdLanche * cod4;
            }
            else if (codLanche == 5) {
                valorTotal = qtdLanche * cod5;
            }
            Console.WriteLine($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("Exercicio 6");
            Console.WriteLine();
            Console.WriteLine("Você deve fazer um programa que leia um valor");
            Console.WriteLine("qualquer e apresente uma mensagem dizendo em ");
            Console.WriteLine("qual dos seguintes intervalos ([0,25], (25,50],");
            Console.WriteLine("(50,75], (75,100]) este valor se encontra.");
            Console.WriteLine("Obviamente se o valor não estiver em nenhum");
            Console.WriteLine("destes intervalos, deverá ser impressa");
            Console.WriteLine("a mensagem 'Fora de intervalo'");
            Console.WriteLine();
            Console.Write("Informe o valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor < 0 || valor > 100) {
                Console.WriteLine("Fora do Intervalo");
            }
            else if (valor <= 25) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50) {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (valor <= 75) {
                Console.WriteLine("Intervalo [50,75]");
            }
            else {
                Console.WriteLine("Intervalo [75,100]");
            }

            Console.WriteLine();
            Console.WriteLine("Exercicio 7");
            Console.WriteLine();
            Console.WriteLine("Leia 2 valores com uma casa decimal (x e y), que");
            Console.WriteLine("devem representar as coordenadas de um ponto em um plano.");
            Console.WriteLine("A seguir, determine qual o quadrante ao qual pertence o");
            Console.WriteLine("ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).");
            Console.WriteLine();
            Console.WriteLine("Se o ponto estiver na origem, escreva a mensagem 'Origem'");
            Console.WriteLine();
            Console.WriteLine("Se o ponto estiver sobre um dos eixos escreva 'Eixo X' ou");
            Console.WriteLine("'Eixo Y', conforme for a situação");
            Console.WriteLine();
            Console.Write("Informe o valor: ");
            Console.WriteLine();
            string[] coordenadas = Console.ReadLine().Split(" ");
            double coordX = double.Parse(coordenadas[0]);
            double coordY = double.Parse(coordenadas[1]);

            if (coordX == 0 && coordY == 0) {
                Console.WriteLine("Origem");
            }
            else if (coordX == 0) {
                Console.WriteLine("Eixo X");
            }
            else if (coordY == 0) {
                Console.WriteLine("Eixo Y");
            }
            else if (coordX >= 0 && coordY >= 0) {
                Console.WriteLine("Q1");
            }
            else if (coordX >= 0 && coordY <= 0) {
                Console.WriteLine("Q2");
            }
            else if (coordX <= 0 && coordY <= 0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }

        }
    }
}
