namespace ATV4_CJ3021912
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //exercicio 1
            Console.WriteLine("exercicio 1\n");
            int dia;
            Console.WriteLine("insira um numero de 1 a 7");
            dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("voce escolheu domingo\n");
                    break;
                case 2:
                    Console.WriteLine("voce escolheu segunda-feira\n");
                    break;
                case 3:
                    Console.WriteLine("voce escolheu terça-feira\n");
                    break;
                case 4:
                    Console.WriteLine("voce escolheu quarta-feira\n");
                    break;
                case 5:
                    Console.WriteLine("voce escolheu quinta-feira\n");
                    break;
                case 6:
                    Console.WriteLine("voce esolheu sexta_feira\n");
                    break;
                case 7:
                    Console.WriteLine("voce escolheu sabado\n");
                    break;
            }

            //exercicio 2
            Console.WriteLine("exercicio 2\n");
            int valor_total, valor_final, pagamento;
            Console.WriteLine("insira o valor total da compra");
            valor_total = int.Parse(Console.ReadLine());
            Console.WriteLine("insira a forma de pagamento pelo numero corespondente: \n1 - dinheiro\n2 - PIX\n3 - debito\n4 - credito");
            pagamento = int.Parse(Console.ReadLine());
            switch (pagamento)
            {
                case 1:
                    valor_final = valor_total - (15 / 100 * valor_total);
                    Console.WriteLine("sua conta saira por: " + valor_final + " reais\n");
                    break;
                case 2:
                    valor_final = valor_total - (10 / 100 * valor_total);
                    Console.WriteLine("sua conta saira por: " + valor_final + " reais\n");
                    break;
                case 3:
                    valor_final = valor_total + (5 / 100 * valor_total);
                    Console.WriteLine("sua conta saira por: " + valor_final + " reais\n");
                    break;
                case 4:
                    valor_final = valor_total + (10 / 100 * valor_total);
                    Console.WriteLine("seu conta saira por: " + valor_final + " reais\n");
                    break;
            }

            //exercicio 3
            Console.WriteLine("exercico 3");

        }
    }
}
