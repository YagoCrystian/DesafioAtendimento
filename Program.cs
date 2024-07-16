using Autoglass.models;
using Filtros;


internal class Program
{
    private static void Main(string[] args)
    {
        List<Atendimento> listaDeAtendimento = LeitorExcel.LerExcel("Atendimento.xls");

        // //?? Exercicio 4.1:
        // Console.WriteLine("Exercicio 4.1: ");
        // LinqFilter.ExercicioQuatroUm(listaDeAtendimento);
        // Console.WriteLine("");

        // //?? Exercicio 4.2:
        // Console.WriteLine("Exercicio 4.2: ");
        // LinqFilter.ExercicioQuatroDois(listaDeAtendimento);
        // Console.WriteLine("");

        // //?? Exercicio 4.3:
        // Console.WriteLine("Exercicio 4.3: ");
        // LinqFilter.ExercicioQuatroTres(listaDeAtendimento);
        // Console.WriteLine("");

        // //?? Exercicio 5:
        // Console.WriteLine("Exercicio 5: ");
        // LinqFilter.ExercicioCinco(listaDeAtendimento);
        // Console.WriteLine("");

        // //?? Exercicio 6:
        // Console.WriteLine("Exercicio 6: ");
        // LinqFilter.ExercicioSeis(listaDeAtendimento);
        // Console.WriteLine("");
    }
};