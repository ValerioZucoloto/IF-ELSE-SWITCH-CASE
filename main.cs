using System;

class MainClass {
  public static void Main (string[] args) {
    int opcao = 0;
    Console.WriteLine ("Escolha uma opção: ");
    Console.WriteLine ("1 - Média");
    Console.WriteLine ("2 - Soma");

    opcao = int.Parse (Console.ReadLine());

    Console.WriteLine ("Informe dois números: ");
    int num1 = int.Parse (Console.ReadLine());
    int num2 = int.Parse (Console.ReadLine());

    switch (opcao) {
      case 1:
       Console.WriteLine("Média: " +  (num1 + num2)/ 2f);
       break;

       case 2:
       Console.WriteLine ("Soma: " + (num1 + num2) );
       break;

       default:
       Console.WriteLine ("Opção inválida!");
       break;
    }

    }
  }
