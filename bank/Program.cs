using bank;
using bank.Titular;

ContaCorrente conta1 = new ContaCorrente("10123-X", 23);

conta1.Nome_agencia = "Agencia central";


Cliente cliente = new Cliente();
cliente.Nome = "Kleuber Aguiar";
cliente.Cpf = "15040585000";
cliente.Profissao = "Programador CSharp";


Console.WriteLine("Titular: " + cliente.Nome);
Console.WriteLine("Conta: " + conta1.Conta);
Console.WriteLine("Numero agencia: " + conta1.Numero_agencia);
Console.WriteLine("Nome agencia: " + conta1.Nome_agencia);

Cliente kleuber = new Cliente();

ContaCorrente conta4 = new ContaCorrente("10623-X", 235);
conta4.Saldo = 200;
conta4.Titular = kleuber;

Console.WriteLine("Saldo: " + conta4.Saldo);
Console.WriteLine("Contas Criadas: " + ContaCorrente.TotalDeContasCriadas);


Console.ReadKey();