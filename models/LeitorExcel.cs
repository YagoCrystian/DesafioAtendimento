
using NPOI.SS.UserModel;

namespace Autoglass.models
{
    internal class LeitorExcel
    {

        public static List<Atendimento> LerExcel(string caminhoDoArquivo)
        {
            var listaDeAtendimentos = new List<Atendimento>();
            IWorkbook arquivo = WorkbookFactory.Create(caminhoDoArquivo);

            ISheet planilha = arquivo.GetSheetAt(0);

            var numeroDeLinhas = planilha.LastRowNum;

            for (int i = 1; i <= numeroDeLinhas; i++)
            {
                IRow linha = planilha.GetRow(i);

                string codigoAtendimento = linha.GetCell(0).NumericCellValue.ToString();
                DateTime dataAbertura = DateTime.Parse(linha.GetCell(1).StringCellValue);
                string seguradora = linha.GetCell(2).StringCellValue;
                string itemDanificado = linha.GetCell(3).StringCellValue;
                double valorDeFranquia = double.Parse(linha.GetCell(4).StringCellValue) / 100;
                string nomeDoSegurado = linha.GetCell(5).StringCellValue;
                string nomeAtendente = linha.GetCell(6).StringCellValue;
                string cidade = linha.GetCell(7).StringCellValue;
                string estado = linha.GetCell(8).StringCellValue;
                string numeroDaApolice = linha.GetCell(9).NumericCellValue.ToString();
                string nomeDoVeiculo = linha.GetCell(10).StringCellValue;

                Atendimento atendimento = new Atendimento(codigoAtendimento, dataAbertura, seguradora, itemDanificado, valorDeFranquia, nomeDoSegurado, nomeAtendente, cidade, estado, numeroDaApolice, nomeDoVeiculo);
                listaDeAtendimentos.Add(atendimento);
            }

            return listaDeAtendimentos;
        }

    }
}