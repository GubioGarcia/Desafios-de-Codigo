using System; // Fornecce tipos fundamentais e funcionalidades básicas, como manipulação de strings, entrada e saída padrão, exceções e etc.
using System.Collections.Generic; // Fornece tipos genericos para coleções de dados
using System.Linq; // Realiza operações de consultas (query) em coleções de dados
using System.Threading.Tasks; // Fornece tipos e métodos para criar e gerenciar tarefas assíncronas

namespace SimulacaoFalhaTeste {
  class Program {
    static void Main(string[] args) {
      // Entrada nome do teste
      Console.WriteLine("Informe o nome do teste: ");
      string nomeTeste = Console.ReadLine() ?? ""; // Usando operador de coalescência nula para fornecer um valor padrão

      // Entrada descrição do erro:
      Console.WriteLine("Informe a descrição do erro: ");
      string descricaoDoErro = Console.ReadLine() ?? "";

      // Exibe descrição do erro em caso de falha
      Console.WriteLine($"O teste falhou. Descrição: {descricaoDoErro}");
    }
  }
}