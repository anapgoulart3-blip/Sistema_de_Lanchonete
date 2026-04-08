using System;

int opcao;
double total = 0;

do
{
    Console.WriteLine("\n===== CARDÁPIO DE BEBIDAS");
    Console.WriteLine(") Coca-Cola (R$ 5,00)");
    Console.WriteLine("2 Suco de Laranja (R$ 6,00)");
    Console.WriteLine("3 Água (R$ 3,00)");
    Console.WriteLine(" Café (R$ 4,00)");
    Console.WriteLine("5 Finalizar pedido");
    Console.WriteLine("================================");

    Console.Write("Escolha uma opção: ");
    opcao int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Você adicionou Coca-Cola ao pedido.");
            total += 5.00;
            break;
        case 2:
            Console.WriteLine("Você adicionou Suco de Laranja ao pedido.");
            total += 6.00;
            break;
        case 3:
            Console.WriteLine("Você adicionou Água ao pedido.");
            total += 3.00;
            break;
        case 4:
            Console.WriteLine("Você adicionou Café ao pedido.");
            total += 4.00;
            Console.WriteLine("\nFinalizando o pedido...");
            break;
            Console.WriteLine("Opção inválida!");
            break;
    }
} while (opсao != 5);

Console.WriteLine($"Valor total do pedido: R$ {total:F2}");
Console.WriteLine("Obrigado pela preferência!");


