using System;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = string.Empty;

           string [] processad = new string[1];

           processad[0] = "Processador :";
            
            Console.WriteLine("");// Espaço


           string [] placam = new string[1];

           placam[0] = "placa mãe :";

            string [] font = new string[1];

            font[0] = "Fonte:";

             string [] memoriar = new string[1];

           memoriar[0] = "Memoria ram pula pula:";

            string [] memori = new string[1];

           memori[0] = "Memoria :";
           Console.WriteLine("-------------------------------------------------------");
           Console.WriteLine("Digite o hardware do computador que você queira saber");
           n = Console.ReadLine();
           Console.WriteLine("-------------------------------------------------------");
            
            Console.WriteLine("");//Espaço

           if (n == "processador intel")
           {
               for (int i = 0; i < n.Length; i++)
               {
                   Console.WriteLine($"{processad[i]} Um processador é uma espécie de microchip especializado. A sua função é acelerar, endereçar, resolver ou preparar dados, dependendo da aplicação.");
               }
           }
            
            Console.WriteLine("");//Espaço

           if (n == "placa mãe assou")
           {
               for (int i = 0; i < n.Length; i++)
               {
                   Console.WriteLine($"{placam[i]} A placa-mãe serve como uma plataforma única para conectar todas as peças de um computador. Uma placa-mãe se conecta A CPU, memória, discos rígidos, unidades ópticas, placa de vídeo, placa de som, e outras portas e placas de expansão directa ou através dos cabos. Ele pode ser considerado como a espinha dorsal de um computador. ");
               }
           }
            
            Console.WriteLine("");//Espaço

           if (n == "memoria ram ")
           {
               for (int i = 0; i < n.Length; i++)
               {
                   Console.WriteLine($"{memoriar[i]} A RAM é a memória de curto prazo de um computador. Em contraste, o HD ou o SDD de um computador é a memória de longo prazo, onde as coisas ficam armazenadas permanentemente ou até serem excluídas.");
               }
           }
            
            Console.WriteLine("");//Espaço

            if (n == "memoria")
           {
               for (int i = 0; i < n.Length; i++)
               {
                    Console.WriteLine($"{memori[i]} memória representa todos os dispositivos que podem armazenar informações, temporária ou permanentemente.");
               }
           }
            
            Console.WriteLine("");//Espaço

            if (n == "fonte")
           {
               for (int i = 0; i < n.Length; i++)
                {
                  Console.WriteLine($"{memori[i]} Uma fonte de alimentação é um equipamento usado para alimentar cargas elétricas. Cada dispositivo eletroeletrônico necessita de uma fonte para prover energia para seus componentes.")   
                }
           }
        }
    }
}
