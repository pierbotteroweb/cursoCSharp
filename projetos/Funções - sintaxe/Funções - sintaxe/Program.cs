using System;

namespace Funções___sintaxe {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("FUNÇÕES");
            Console.WriteLine("EM ORIENTAÇÃO A OBJETOS, FUNÇÕES EM CLASSES RECEBEM O NOME DE MÉTODOS");
            Console.WriteLine();
            Console.WriteLine("Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.");
            Console.WriteLine();
            Console.WriteLine("Em vez de fazer uma estrutura de if else para cada deduzir o maior número,");
            Console.WriteLine("Podemos delegar essa logica para uma função que recebe os 3 números como parametro.");
            Console.WriteLine("double resultado = Maior(n1, n2, n3)");
            Console.WriteLine();
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            // PARA INICIAR UM DEBUGING A PARTIR DA LINHA ABAIXO,
            // BASTA SELECIONAR A LINHA E CLICAR F9, CRIANDO ASSIM UM BREAKPOINT
            int n3 = int.Parse(Console.ReadLine());
            // APÓS DIGITARMOS O SEGUNDO DIGITO, O VISUAL CODE EXIBE PAINEIS 
            // PARA ANALISE DO NOSSO CÓDIGO. NA ABA AUTOS, TEMOS LISTADAS
            // AS VARIÁVEIS MAIS RELEVANTES DO NOSSO CÓDIGO. 
            // NA ABA LOCALS TEMOS TODAS AS VARIAVEIS, SEUS VALORES E TIPOS
            // QUE CONTAM DENTRO DO ESCOPO ANALISADO NO MOMENTO.

            // PARA QUE O NOSSO DEBUGGING CONTINUE POR DENTRO DA FUNÇÃO EXECUTADA,
            // CLICAMOS F11 QUANDO CHEGAR A SUA VEZ NO PROCESSO. 
            
            double resultado = Maior(n1, n2, n3);
            // CLICANDO F10, VOLTAMOS PARA A EXECUÇÃO DO CÓDIGO E DIGITANDO O 3 VALOR
            // VOLTAMOS PARA O VS COM A LINHA SEGUINTE DE EXECUÇÃO MARCADA EM AMARELO,
            // E COM OS VALORES E DADOS NOS PAINEIS, ATUALIZADOS. 
            Console.WriteLine();
            Console.WriteLine("Maior = " + resultado);
            Console.WriteLine("Nossa função Maior ficará após o nosso static void Main");
            Console.WriteLine("static int Maior(int a, int b, int c){}.");
            Console.WriteLine();
            Console.WriteLine("Como nossa Main function é static, a funçaõ executada dentro do seu escopo");
            Console.WriteLine("precisa ser static também.");
            Console.WriteLine("O retorno da nossa função será um inteiro, por isso tipamos ela com o int");
            Console.WriteLine("Cada parametro da função precisa ser tipado também.");

            // PARA INTERROMPER O DEBUGGING USAR SHIFT F5.

            // NO DEBUGGING DE DENTRO DA FUNÇÃO MAIOR, ACOMPANHE OS VALORES NO
            // PAINEL EM CADA ETAPA DA FUNÇÃO
        }

        static int Maior(int a, int b, int c) {
            int m;
            if(a > b && a > c) {
                m = a;
            } else if( b > c) {
                m = b;
            } else {
                m = c;
            }
            return m;
        }
    }
}
