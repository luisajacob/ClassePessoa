using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPessoa
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando, creiando objeto
            Pessoa obj = new Pessoa();

            //solicitando ao usuário o nome
            Console.WriteLine("Digite seu nome: ");
            obj.nome= Console.ReadLine();

            //solicitando aqo usuáriol a idade
            Console.WriteLine("Digite sua idade: ");
            obj.idade = int.Parse(Console.ReadLine());

            obj.ExibirDados();

            Console.ReadKey();
        }
    }
}
