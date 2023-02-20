using Desafio;

Console.Write("Valor final da compra: R$ ");
double valorFinal = double.Parse(Console.ReadLine());

Console.Write("Pagamento: R$ ");
double pagamento = double.Parse(Console.ReadLine());

Troco troco = new Troco(valorFinal, pagamento);

Console.WriteLine("\n" + troco);