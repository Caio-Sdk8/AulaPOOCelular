using System;

namespace aulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monitorador de celular, para pessoas como você, que não sabem se está ligado ou não");

            celular novo = new celular();
            celular cadas = new celular();
            novo.ligado = false;
            
            Console.WriteLine($"{(novo.ligado?"desligar":"ligar")}");
            do
            {

                Console.WriteLine($@"
            ______________________________
            |           Menu             |
            |   1 -{(novo.ligado?"desligar":"ligar")}  |
            |                            |
            |   2 - Fazer uma ligação    |
            |                            |
            |   3 - Enviar uma mensagem  |
            |                            |
            | 4 - Cadastrar propriedades |
            |                            |
            | 5 - Listar propriedades    |
            ------------------------------");
                int resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        if (!novo.ligado)
                        {
                            novo.ligado = true;

                            Console.WriteLine("Teu celular está ligando, você será levado de volta ao menu");

                            Console.WriteLine(@"
            ______________________________
            |           Menu             |
            |   1 - ligar ou desligar    |
            |                            |
            |   2 - Fazer uma ligação    |
            |                            |
            |   3 - Enviar uma mensagem  |
            |                            |
            | 4 - Cadastrar propriedades |
            |                            |
            | 5 - Listar propriedades    |
            ------------------------------");
                            resposta = int.Parse(Console.ReadLine());
                            switch (resposta)
                            {
                                case 1:
                                    Console.WriteLine("Teu celular está Ligado, certeza que deseja desligar ele? 1-sim 2- não");
                                    int desligar = int.Parse(Console.ReadLine());

                                    switch (desligar)
                                    {
                                        case 1:
                                            Console.WriteLine("Seu celular será desligado, tenha um bom dia");
                                            novo.ligado = false;
                                            break;
                                        case 2:
                                            Console.WriteLine("então você será levado ao menu novamente");
                                            break;
                                        default:
                                            Console.WriteLine("TU É MUITO BURRO PORRA TÁ ESCRITO 1 OU 2, CUSTA ESCREVER CERTO SEU RESTO DE ABORTO.");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Para quem deseja ligar?");
                                    string persona2 = Console.ReadLine();

                                    Console.WriteLine($"{cadas.ligar()} {persona2}");

                                    break;
                                case 3:
                                    Console.WriteLine("Para quem deseja enviar a mensagem?");
                                    string persoa2 = Console.ReadLine();

                                    Console.WriteLine("Digite a mensagem");
                                    Console.ReadLine();

                                    Console.WriteLine($"{cadas.mensagem()} {persoa2} espere uma resposta");
                                    break;
                                case 4:
                                    Console.WriteLine("Qual o modelo do celular?");
                                    cadas.modelo = Console.ReadLine();

                                    Console.WriteLine("Qual a cor dele?");
                                    cadas.cor = Console.ReadLine();

                                    Console.WriteLine("Qual o tamanho dele?");
                                    cadas.tamanho = Console.ReadLine();

                                    Console.WriteLine("Cadastro feito, você será levado ao menu");
                                    break;
                                case 5:
                                    Console.WriteLine("Listagem do Celular");

                                    Console.WriteLine($"Modelo do celular: {cadas.modelo}");
                                    Console.WriteLine($"A cor do celular: {cadas.cor}");
                                    Console.WriteLine($"O tamanho do celular: {cadas.tamanho}");

                                    Console.WriteLine("Após a listagem você será novamente levado ao menu.");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Teu celular está Ligado, certeza que deseja desligar ele? 1-sim 2- não");
                            int desligar = int.Parse(Console.ReadLine());
                            novo.ligado = false;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Para quem deseja ligar?");
                        string persona = Console.ReadLine();

                        Console.WriteLine($"{cadas.ligar()} {persona}");
                        break;
                    case 3:
                        Console.WriteLine("Para quem deseja enviar a mensagem?");
                        string persoa = Console.ReadLine();

                        Console.WriteLine("Digite a mensagem");
                        Console.ReadLine();

                        Console.WriteLine($"{cadas.mensagem()} {persoa} espere uma resposta");
                        break;
                    case 4:
                        Console.WriteLine("Qual o modelo do celular?");
                        cadas.modelo = Console.ReadLine();

                        Console.WriteLine("Qual a cor dele?");
                        cadas.cor = Console.ReadLine();

                        Console.WriteLine("Qual o tamanho dele?");
                        cadas.tamanho = Console.ReadLine();

                        Console.WriteLine("Cadastro feito, você será levado ao menu");
                        break;
                    case 5:
                        Console.WriteLine("Listagem do Celular");

                        Console.WriteLine($"Modelo do celular: {cadas.modelo}");
                        Console.WriteLine($"A cor do celular: {cadas.cor}");
                        Console.WriteLine($"O tamanho do celular: {cadas.tamanho}");

                        Console.WriteLine("Após a listagem você será novamente levado ao menu.");
                        break;
                    default:
                        break;
                }
            } while (novo.ligado);

        }


    }
}
