using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"O aluno: {Nome} | Notas: {Nota1} e {Nota2}");

        }

        public double CalcularMedia()
        {
            double media;
            return media = (Nota1 + Nota2) / 2;
           
        }

    }

}
