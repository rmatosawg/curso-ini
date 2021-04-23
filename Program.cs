using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;

            while (contador < 5)
            {
                int numero_aleatorio;

                numero_aleatorio = new Random().Next(1, 100);

                Console.WriteLine("numero antes de somar:" + numero_aleatorio.ToString());

                Console.Write("Escreva um valor para somar ou digite EXIT para sair:");

                int valor_digitado_como_inteiro = 0;
                bool resultado_validacao;
                string valor_digitado;
                do
                {
                    valor_digitado = Console.ReadLine();

                    if (valor_digitado == "EXIT")
                    {
                        break;
                    }

                    resultado_validacao = int.TryParse(valor_digitado, out valor_digitado_como_inteiro);

                    if (resultado_validacao == true && valor_digitado_como_inteiro <= 100)
                    {
                        Console.WriteLine("ok = valor válido;");
                    }
                    else if (valor_digitado_como_inteiro > 100)
                    {
                        Console.WriteLine("ok, mas ... valor é maior que 100; vou considerar 100");
                        valor_digitado_como_inteiro = 100;
                        valor_digitado = valor_digitado_como_inteiro.ToString();
                    }
                    else
                    {
                        Console.WriteLine("BURRO!!!!!!!!!!!!!");
                    }
                } while (resultado_validacao == false || valor_digitado_como_inteiro > 100);

                if (valor_digitado == "EXIT")
                    break;

                contador = contador + 1;

                int numero_aleatorio_mais_10 = numero_aleatorio + valor_digitado_como_inteiro;

                string a;

                a = "douglas: ";

                a = a + numero_aleatorio.ToString();

                a = a + " + " + valor_digitado + "= ";

                a = a + numero_aleatorio_mais_10.ToString();

                Console.WriteLine("contador:" + contador.ToString() + " ==>" + a);

          
                Console.ReadKey();

            }

            Console.WriteLine("você digitou " + contador.ToString() + "vezes");
            Console.ReadKey();
        }
    }
}
