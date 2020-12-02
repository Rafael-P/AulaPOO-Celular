using System;

namespace AulaPOO_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            Console.WriteLine("Qual a cor do celular ?");
            celular.cor = Console.ReadLine();

            Console.WriteLine("Qual o modelo do celular ?");
            celular.modelo = Console.ReadLine();

            Console.WriteLine("Qual o tamanho do celular ?");
            celular.tamanho = Console.ReadLine();

            Console.WriteLine("O celular está ligado s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                celular.ligado = true;
            }else{
                celular.ligado = false;
            }

            //MENU
            if (celular.ligado == true)
            {
                int opcao = 0;
                do
                {
                    
                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("[1] - Ligar");
                    Console.WriteLine("[2] - Enviar uma mensagem");
                    Console.WriteLine("[3] - Fazer uma ligação");
                    Console.WriteLine("[0] - Desligar");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("O celular ja está ligado");
                            break;
                        case 2:
                            Console.WriteLine("Para que número deseja enviar uma mensagem");
                            Console.ReadLine();
                            Console.WriteLine("Escreva a mensagem");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Para que número deseja ligar");
                            Console.ReadLine();
                            Console.WriteLine("Chamando...");
                            Console.WriteLine("Alô");
                            break;
                        case 0:
                            Console.WriteLine("Desligando celular");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                    
                } while (opcao != 0);


            }else{
                Console.WriteLine("Ligue o celular");
            }


        }//FIM DO MAIN
    }
}
