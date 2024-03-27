using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b, c, d, e, f, g, h, y;
            int x;
            
            Console.WriteLine("Formulário para criação de currículo.");
            Console.ReadLine();

            Console.WriteLine("Preencha as perguntas abaixo: ");
            Console.ReadLine();

            Console.WriteLine("Qual seu nome completo?");
            a = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu contato telefônico?");
            y = (Console.ReadLine());

            Console.WriteLine("Qual seu e-mail?");
            b = Console.ReadLine();

            Console.WriteLine("Qual a vaga de trabalho pretendida?");
            c = Console.ReadLine();

            Console.WriteLine("Faça um breve resumo do seu objetivo profissional: ");
            d = Console.ReadLine();

            Console.WriteLine("Você já teve experiências profissionais? sim ou não?");
            e = Console.ReadLine();

            if(e == "sim")
            {
                Console.WriteLine("Descreva suas experiências profissionais na seguinte sequência: Cargo, empresa, período e atividades");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Qual seu diferencial? Já participou de algum projeto na faculdade?");
                Console.ReadLine();
            }

            Console.WriteLine("Qual sua formação acadêmica? Informe a instituição, o curso e o status");
            f = Console.ReadLine();

            Console.WriteLine("Quais suas habilidades profissionais?");
            g = Console.ReadLine();

            Console.WriteLine("Além do Português, você fala outro idioma? Se sim, qual nível?");
            h = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Nome completo: " + a);
            Console.WriteLine();
            Console.WriteLine(x + "anos");
            Console.WriteLine();
            Console.WriteLine("Contatos: " + y + " | " + b);
            Console.WriteLine();
            Console.WriteLine("Vaga pretendida: " +  c);
            Console.WriteLine();
            Console.WriteLine("Objetivo profissional: " +  d);
            Console.WriteLine();
            Console.WriteLine("Experiências profissionais: " +  e);
            Console.WriteLine();
            Console.WriteLine("Formação Acadêmica: " + f);
            Console.WriteLine();
            Console.WriteLine("Habilidades Profissionais: " + g);
            Console.WriteLine();
            Console.WriteLine("Idioma: " + h);



        }
    }
}
