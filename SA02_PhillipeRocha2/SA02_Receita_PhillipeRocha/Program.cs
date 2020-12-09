using System;

namespace SA02_Receita_PhillipeRocha
{
    class Program
    {
        static void Main(string[] args)
        {
        inicio:




            Console.WriteLine(" _______________________________________________ ");  // menu 
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|            Receita de culinária               |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("| 1 -  Registrar a culinária                    |");
            Console.WriteLine("| 2 -  Editar a culinária                       |");
            Console.WriteLine("| 3 -  Elimitar receita de culinária            |");
            Console.WriteLine("| 4 -  Sair                                     |");
            Console.WriteLine("|_______________________________________________|");


            int A;
            A = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Quantos Receitas você quer adicionar? ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                switch (A)
                {

                    case 1:
                        //no menu 1

                        Console.WriteLine("Digite o nome da receita: ");
                        string nomereceita = (Console.ReadLine());
                   

                        Console.WriteLine("Digite o tempo de preparação: ");// nao esquecer colocar o tempo --:--
                        double tempopreparacao = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o grau de dificuldade: ");
                        double graudificuldade = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o número de pessoa para preparação: ");
                        double numpessoa = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a categoria: ");
                        string Categolinaria = (Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Clear();
                       

                        break;
                }
               
            }

            switch (A)
            {
                case 2:


                    {
                        // menu 2
                        Console.WriteLine(" _________________________________");// editar a culinaria 
                        Console.WriteLine("|---------------------------------|");
                        Console.WriteLine("| Editar a culinária              |");
                        Console.WriteLine("|---------------------------------|");
                        Console.WriteLine("| Digite as opções abaixo:        |");
                        Console.WriteLine("| 1 -Editar a receita             |");
                        Console.WriteLine("| 2 -Editar tempo de preparação   |");
                        Console.WriteLine("| 3 -Editar o grau de dificuldade |");
                        Console.WriteLine("| 4 -Editar quantidade da pessoa  |");
                        Console.WriteLine("| 5 -Editar a categoria           |");
                        Console.WriteLine("| 0 -Sair                         |");
                        Console.WriteLine("|_________________________________|");
                        int B;
                        B = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();



                        switch (B)
                        {

                            //editar na receita

                            case 1:

                                Console.WriteLine("*****************************");
                                Console.WriteLine("Alterar Receita");
                                Console.WriteLine("*****************************");
                                string nomereceita = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Alteração concluido com sucesso! ");
                                Console.WriteLine("*********************************");
                                Console.WriteLine();
                                Console.WriteLine();

                                break;
                            // editar no tempo de peparação

                            case 2:
                                Console.WriteLine("*****************************");
                                Console.WriteLine("Alterar Tempo de preparação ");
                                Console.WriteLine("*****************************");
                                double tempopreparacao = double.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Alteração concluido com sucesso! ");
                                Console.WriteLine("*********************************");
                                Console.WriteLine();
                                Console.WriteLine();



                                break;
                            // editar o grau de dificuldade

                            case 3:
                                Console.WriteLine("*****************************");
                                Console.WriteLine("Alterar o grau de dificuldade");
                                Console.WriteLine("*****************************");
                                double graudificuldade = double.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Alteração concluido com sucesso! ");
                                Console.WriteLine("*********************************");
                                Console.WriteLine();
                                Console.WriteLine();


                                break;
                            // editar quantidade de pessoas
                            case 4:
                                Console.WriteLine("*****************************");
                                Console.WriteLine("Alterar quantidade de pessoa");
                                Console.WriteLine("*****************************");
                                double numpessoa = double.Parse(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Alteração concluido com sucesso! ");
                                Console.WriteLine("*********************************");
                                Console.WriteLine();
                                Console.WriteLine();


                                break;
                            // editar a categoria
                            case 5:
                                Console.WriteLine("*****************************");
                                Console.WriteLine("Alterar a categoria");
                                Console.WriteLine("*****************************");
                                string Categolinaria = (Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("*********************************");
                                Console.WriteLine("Alteração concluido com sucesso! ");
                                Console.WriteLine("*********************************");
                                Console.WriteLine();
                                Console.WriteLine();


                                break;
                            // fim da operação
                            default:
                                Console.WriteLine("Obrigado pela operação!");
                                break;


                        }




                    }
                    break;

            }
            switch (A)
            {
                case 3:

                    Console.Clear();
                    break;
            }
            switch (A)
            {
                default:
                    Console.WriteLine("Finalizado com sucesso! ");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Aperta Enter para voltar menu");
                    string voltar = Console.ReadLine();
                    Console.Clear();

                    break;

            }
            Console.ReadLine();



            goto inicio;
        }
    }
}
