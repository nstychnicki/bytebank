using bytebank.Contas;
using bytebank.Titular;
//namespaces

//objeto
/*ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;
//valor inicial
Console.WriteLine("Saldo inicial do André = " +  contaDoAndre.saldo);

//depósito
contaDoAndre.Depositar(100);
Console.WriteLine("Andre depois do depósito = " + contaDoAndre.saldo);

//saque
if (contaDoAndre.Sacar(50) == true)
{
    Console.WriteLine("Andre depois do saque = " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Não foi possível realizar o saque");
}

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 300;

Console.WriteLine("Saldo da inicial da Maria = " + contaDaMaria.saldo);
//transferencia
contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Maria depois da tranferência = " + contaDaMaria.saldo);
Console.WriteLine("Andre depois da transferência = " + contaDoAndre.saldo);
*/

/*Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "123456789";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("Cpf = " + conta.titular.cpf);
Console.WriteLine("Profissao = " + conta.titular.profissao);
Console.WriteLine("Nº Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("Nº Agência = " + conta.numero_agencia);

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new Cliente();
conta2.titular.nome = "José Souza";
conta2.titular.profissao = "Tester";
conta2.titular.cpf = "987654321";
conta2.conta = "9999-X";
conta2.numero_agencia = 18;
conta2.saldo = 500;

Console.WriteLine(conta2.titular.nome);*/

//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(-10); 
//Console.WriteLine(conta3.GetSaldo());

ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
conta4.SetSaldo(500);
conta4.Titular = new Cliente();

Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_agencia);

