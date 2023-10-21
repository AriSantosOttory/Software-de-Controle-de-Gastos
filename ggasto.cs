using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        DespesasApp despesasApp = new DespesasApp();

        int opcao = 0;
        while (opcao != 5)
        {
            Console.WriteLine("Digite 1 para registrar despesa");
            Console.WriteLine("Digite 2 para visualizar relatório de despesas");
            Console.WriteLine("Digite 3 para visualizar relatório de despesas por categoria");
            Console.WriteLine("Digite 4 para excluir despesa");
            Console.WriteLine("Digite 5 para sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    despesasApp.RegistrarDespesa();
                    break;
                case 2:
                    despesasApp.VisualizarRelatorioGeral();
                    break;
                case 3:
                    despesasApp.VisualizarRelatorioPorCategoria();
                    break;
                case 4:
                    despesasApp.ExcluirDespesa();
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}

public class Despesa
{
    public string Descricao { get; set; }
    public double Valor { get; set; }
    public string Categoria { get; set; }
    public DateTime Data { get; set; }

    public Despesa(string descricao, double valor, string categoria, DateTime data)
    {
        Descricao = descricao;
        Valor = valor;
        Categoria = categoria;
        Data = data;
    }
}

public class DespesasApp
{
    private List<Despesa> _despes