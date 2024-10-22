
using POOCalculoIdade;

CalculoIdade POO0 = new CalculoIdade();
Console.WriteLine("progrma que calcula a idade de uma pesoa");
Console.Write("digite o nome: ");
POO0.Nome = Console.ReadLine() ?? "";
Console.Write("digite o ano de nacimento: ");
POO0.AnoNacimento = Convert.ToInt32(Console.ReadLine() ?? "");
POO0.ExibirDados();
