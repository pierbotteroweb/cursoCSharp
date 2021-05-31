using System;

namespace Course_Operadores_Comparativos {
    class Program {
        static void Main(string[] args) {
            int a = 10;

            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();
            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            bool c9  = 2 > 3 || 4 != 5;
            bool c10 = !(2 > 3) && 4 != 5;

            bool c11 = 10 < 5;
            // PESQUISANDO A ORDEM DE PRECEDENCIA DE OPERADORES, 
            // VEREMOS QUE O OPERADOR && TME PRECEDENCIA SOBR EO ||
            // POR ISSO A COMPARAÇÃO ABAIXO SERÁ TRUE. 
            // SE SEGUISSEMOS A ORDEM DA ESQUERDA PARA A DIREITA, O RESULTADO SERIA FALSE
            bool c12 = c9 || c10 && c11;

            Console.WriteLine(c9);
            Console.WriteLine(c10);
            Console.WriteLine(c11);
            Console.WriteLine(c12);
            Console.WriteLine();
            Console.WriteLine("===================OPERADORES CONDICIONAIS========================");
            Console.WriteLine();

            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2==0) {
                Console.WriteLine("Par!");
            } else {
                Console.WriteLine("Impar!");
            }

            Console.WriteLine("====estrutura Condicional Encadeada=======");
            Console.WriteLine("Se quisessemos fazer uma condicional para exibir uma mensagem dependendo da hora");
            Console.WriteLine("Poderiamos usar 3 ifs simples");
            Console.WriteLine();
            Console.WriteLine("If hora < 12 | Bom dia!");
            Console.WriteLine("If hora >= 12 && hora < 18 | Boa tarde!");
            Console.WriteLine("If hora >= 18 | Boa noite!");
            Console.Write("Informe a hora atual: ");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            if (hora >= 12 && hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            if (hora > 18) {
                Console.WriteLine("Boa noite!");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Mas fazer uma estrutura condicional dessa forma");
            Console.WriteLine("aumenta as chances do codigo ficar inconsistente");
            Console.WriteLine("por fator humano, uma vez que uma condicional não impede");
            Console.WriteLine("necessáriamente a outra de ser executada.");
            Console.WriteLine("No nosso exemplo, além do codigo ficar mais consistente,");
            Console.WriteLine("a segunda condicional fica mais simplificada, uma vez que a");
            Console.WriteLine("primeira condicional já é rejeitada.");
            Console.WriteLine("Fazemos else if (hora < 18 ) em vez de If (hora >= 12 && hora < 18).");
            Console.WriteLine("");
            Console.WriteLine("E a terceira parte da condicional pode ser só um else já que");
            Console.WriteLine("as outras duas de tres possibilidades já foram descartadas.");
            Console.WriteLine("");

            Console.Write("Informe a hora atual: ");
            int hora2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (hora2 < 12) {
                Console.WriteLine("Bom dia!");
            } else if (hora2 < 18) {
                Console.WriteLine("Boa tarde!");
            } else  {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
