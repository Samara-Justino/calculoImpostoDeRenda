using System;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            long cpf = long.Parse(Console.ReadLine());
            Console.Write("Renda anual: ");
            double rendaAnual = double.Parse(Console.ReadLine());
            Console.Write("Dependentes: ");
            int dependentes = int.Parse(Console.ReadLine());

            double rendaLiquida = rendaAnual - (dependentes * 110.0);
       
            Console.WriteLine("===========================================");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Dependentes: " + dependentes);
            Console.WriteLine("Renda anual R$" + rendaAnual.ToString("F2"));
            Console.WriteLine("Renda líquida R$" + rendaLiquida.ToString("F2"));

            double imposto;

            if (rendaLiquida <= 1903.98 )
            {
                Console.WriteLine("Isento");
            }

            if (rendaLiquida > 1903.98 && rendaLiquida <= 2826.65)
            {
                Console.WriteLine("Alíquota 7.5%");
                imposto = rendaLiquida * (7.5 / 100.0);
                Console.WriteLine("Imposto R$ " + imposto.ToString("F2"));
            }
            if (rendaLiquida > 2826.65 && rendaLiquida <= 3751.05)
            {
                Console.WriteLine("Alíquota 15%");
                imposto = rendaLiquida * (15.0 / 100.0);
                Console.WriteLine("Imposto R$ " + imposto.ToString("F2"));
            }
            if (rendaLiquida > 3751.05  && rendaLiquida <= 4664.68)
            {
                Console.WriteLine("Alíquota 22,5%");
                imposto = rendaLiquida * (22.5 / 100.0);
                Console.WriteLine("Imposto R$ " + imposto.ToString("F2"));
            }
            if (rendaLiquida > 4664.68)
            {
                Console.WriteLine("Alíquota 27,5%");
                imposto = rendaLiquida * (27.5 / 100.0);
                Console.WriteLine("Imposto R$ " + imposto.ToString("F2"));
            }

       
           



        }
    }
}
