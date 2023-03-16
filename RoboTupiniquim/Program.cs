namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Digite o tamanho do grid X: ");
            int gridx = int.Parse(Console.ReadLine());

            Console.Write(" Digite o tamanho do grid y: ");
            int gridy = int.Parse(Console.ReadLine());
                   
            int contador = 0;

            do
            {
                Console.Write(" Digite a posição inicial x: ");
                int posicaoinicialx = int.Parse(Console.ReadLine());

                Console.Write(" Digite a posição inicial y: ");
                int posicaoinicialy = int.Parse(Console.ReadLine());

                Console.Write(" Digite a direção: ");
                char direçao = Convert.ToChar(Console.ReadLine());
                
                Console.Write(" Digite o comando: ");

                string comando = Console.ReadLine();

                char[] comandochar = comando.ToCharArray();

                for (int i = 0; i < comandochar.Length; i++)
                {
                    if (comandochar[i] == 'M')
                    {
                        if (direçao == 'N')
                        {
                            posicaoinicialy++;
                        }
                        else if (direçao == 'S')
                        {
                            posicaoinicialy--;
                        }
                        else if (direçao == 'L')
                        {
                            posicaoinicialx++;

                        }
                        else if (direçao == 'O')
                        {
                            posicaoinicialx--;
                        }
                    }
                    if (comandochar[i] == 'E')
                    {
                        if (direçao == 'N')
                        {
                            direçao = 'O';
                        }
                        else if (direçao == 'O')
                        {
                            direçao = 'S';
                        }
                        else if (direçao == 'S')
                        {
                            direçao = 'L';
                        }
                        else if (direçao == 'L')
                        {
                            direçao = 'N';
                        }
                    }
                    if (comandochar[i] == 'D')
                    {
                        if (direçao == 'N')
                        {
                            direçao = 'L';
                        }
                        else if (direçao == 'L')
                        {
                            direçao = 'S';
                        }
                        else if (direçao == 'S')
                        {
                            direçao = 'O';
                        }
                        else if (direçao == 'O')
                        {
                            direçao = 'N';
                        }

                    }
                }

                Console.WriteLine($"{posicaoinicialx } {posicaoinicialy} {direçao}" );

                contador++;
            } while ( contador != 2);                       
       }
    }    
}    
