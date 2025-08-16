
using Escola;
using System.Net.Http.Headers;
class Program {
    static void Main()
    {

        Aluno[] turma = new Aluno[3];

        turma[0] = new Aluno();
        Console.WriteLine("Escreva o nome do primeiro aluno: ");
        turma[0].Nome = Console.ReadLine();
        Console.WriteLine("Escreva a primeira nota: ");
        turma[0].Nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva a segunda nota: ");
        turma[0].Nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        turma[1] = new Aluno();

        Console.WriteLine("Escreva o nome do segundo aluno: ");
        turma[1].Nome = Console.ReadLine();
        Console.WriteLine("Escreva a primeira nota: ");
        turma[1].Nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva a segunda nota: ");
        turma[1].Nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        turma[2] = new Aluno();

        Console.WriteLine("Escreva o nome do terceiro aluno: ");
        turma[2].Nome = Console.ReadLine();
        Console.WriteLine("Escreva a primeira nota: ");
        turma[2].Nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva a segunda nota: ");
        turma[2].Nota2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("------- Lista de Alunos -------");
        for (int i = 0; i < turma.Length; i++)
        {
            turma[i].ExibirInformacoes();

            Console.WriteLine($"Media: {turma[i].CalcularMedia()}");
            Console.WriteLine();
        }

        //Console.WriteLine($"{turma[1].Nome} - {turma[1].Nota1} - {turma[1].Nota2}");
        //Console.WriteLine($"{turma[2].Nome} - {turma[2].Nota1} - {turma[2].Nota2}");
        //Console.WriteLine($"{turma[3].Nome} - {turma[3].Nota1} - {turma[3].Nota2}");

    }
}