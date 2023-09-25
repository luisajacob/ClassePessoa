using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPessoa
{
    internal class Pessoa
    {
        //Definição de atributos da Classe Pessoa
        public string nome { get; set; }
        public int idade { get; set; }

        //Método para exibir o nome e idade da pessoa
        public void ExibirDados()
        {
            Console.WriteLine("Olá, " + nome + ", você tem " + idade + " anos.");
        }
    }
}
