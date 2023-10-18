using System;

namespace AvaliacaoDadosTeste {
  class Program {
    static void Main(string[] args) {
      // Solicita ao usuário a entrada para o número de testes passados
      int testesPassados = Convert.ToInt32(Console.ReadLine());

      // Solicita ao usuário a entrada para o número total de testes
      int totalTestes = Convert.ToInt32(Console.ReadLine());

      decimal taxaSucesso = (decimal)testesPassados / totalTestes * 100;

      if (taxaSucesso >= 80) {
        Console.WriteLine("A funcionalidade esta pronta para lancamento.");
      } else {
        Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");
      }
    }
  }
}