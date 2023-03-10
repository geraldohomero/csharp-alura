using byteBank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pós-deposito = " + contaDoAndre.saldo);