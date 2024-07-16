using Autoglass.models;

namespace Filtros
{
    internal class LinqFilter
    {
        //! Qual é o maior valor de franquia pago por um Segurado? (0,5)
        public static void ExercicioUm(List<Atendimento> atendimentos)
        {
            double maiorValorFranquia = atendimentos.Max(x => x.ValorDeFranquia);
            Console.WriteLine($"O maior valor de franquia pago por um Segurado: {maiorValorFranquia:C}");

        }
        //! Quantos atendentes temos em nossa Central? Conte sem repetição. (0,5)
        public static void ExercicioDois(List<Atendimento> atendimentos)
        {
            int numeroDeAtendentes = atendimentos.DistinctBy(x => x.NomeAtendente).Count();
            Console.WriteLine($"Numero de atendentes: {numeroDeAtendentes}");

        }
        //! Quantos atendimentos temos mensalmente? Faça uma lista ordenada ascendente dos meses e as respectivas quantidades. (1,00)
        public static void ExercicioTres(List<Atendimento> atendimentos)
        {
            var atendimentosMensais = atendimentos
                                        .GroupBy(x => new
                                        {
                                            MesString = x.DataAbertura.ToString("MMMM"),
                                            Mes = x.DataAbertura.Month

                                        }).Select(g => new
                                        {
                                            Mes = g.Key.Mes,
                                            MesString = g.Key.MesString,
                                            Quantidade = g.Count()
                                        }).OrderBy(y => y.Mes);
            foreach (var atendimento in atendimentosMensais)
            {
                Console.WriteLine($"{atendimento.MesString}: {atendimento.Quantidade} atendimentos");
            }
        }
        //!Faça um TOP 5 de Seguradoras que mais tiveram atendimentos. 
        //!Faça um TOP 5 dos veículos que mais apareceram na lista. 
        //!Faça um TOP 3 de Itens danificados que mais apareceram na lista. (1,00)
        public static void ExercicioQuatroUm(List<Atendimento> atendimentos)
        {
            var topCincoSeguradoras = atendimentos
                                        .GroupBy(x => x.Seguradora)
                                        .Select(g => new
                                        {
                                            Seguradora = g.Key,
                                            Quantidade = g.Count()
                                        }).OrderByDescending(x => x.Quantidade)
                                        .Take(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {topCincoSeguradoras.ElementAt(i).Seguradora}: {topCincoSeguradoras.ElementAt(i).Quantidade} atendimentos");
            }
        }
        public static void ExercicioQuatroDois(List<Atendimento> atendimentos)
        {
            var topCincoVeiculos = atendimentos
                                        .GroupBy(x => x.NomeDoVeiculo)
                                        .Select(g => new
                                        {
                                            Veiculo = g.Key,
                                            Quantidade = g.Count()
                                        }).OrderByDescending(x => x.Quantidade)
                                        .Take(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {topCincoVeiculos.ElementAt(i).Veiculo}: {topCincoVeiculos.ElementAt(i).Quantidade} atendimentos");
            }

        }
        public static void ExercicioQuatroTres(List<Atendimento> atendimentos)
        {
            var topTresDanificados = atendimentos
                                        .GroupBy(x => x.ItemDanificado)
                                        .Select(g => new
                                        {
                                            Danificado = g.Key,
                                            Quantidade = g.Count()
                                        }).OrderByDescending(x => x.Quantidade)
                                        .Take(3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {topTresDanificados.ElementAt(i).Danificado}: {topTresDanificados.ElementAt(i).Quantidade} atendimentos");
            }
        }
        //!Referente aos segurados. Quantos segurados temos em nossa base? Faça um TOP 5 do total de acionamento dos segurados com o valor de franquia e a quantidade de atendimentos abertos. (1,00)
        public static void ExercicioCinco(List<Atendimento> atendimentos)
        {
            var quantidadeDeAcionamentos = atendimentos
                                            .GroupBy(x => x.NomeDoSegurado)
                                            .Select(g => new
                                            {
                                                NomeDoSegurado = g.Key,
                                                QuantidadeDeAcionamentos = g.Count(),
                                                ValorDeFranquia = g.Sum(y => y.ValorDeFranquia),

                                            }).OrderByDescending(x => x.QuantidadeDeAcionamentos)
                                            .Take(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}º - {quantidadeDeAcionamentos.ElementAt(i).NomeDoSegurado} - {quantidadeDeAcionamentos.ElementAt(i).ValorDeFranquia:C} - {quantidadeDeAcionamentos.ElementAt(i).QuantidadeDeAcionamentos} atendimentos");

            }
        }
        //!Quais os estados com maior número de atendimentos abertos por mês. Crie um TOP 5 dessa informação (1,00)
        public static void ExercicioSeis(List<Atendimento> atendimentos)
        {
            var topCincoEstados = atendimentos
                                    .GroupBy(x => new
                                    {
                                        MesString = x.DataAbertura.ToString("MMMM/yyyy"),
                                        Mes = x.DataAbertura.Month,
                                        Estado = x.Estado
                                    }).Select(x => new
                                    {
                                        Mes = x.Key.Mes,
                                        MesString = x.Key.MesString,
                                        Estado = x.Key.Estado,
                                        Quantidade = x.Count()
                                    }).OrderByDescending(x => x.Quantidade)
                                    .Take(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}º -  {topCincoEstados.ElementAt(i).MesString} - {topCincoEstados.ElementAt(i).Estado}: {topCincoEstados.ElementAt(i).Quantidade} atendimentos");
            }
        }
    }
}