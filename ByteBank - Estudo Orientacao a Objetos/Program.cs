//Criando o objeto - Criando uma conta corrente
using ByteBank___Estudo_Orientacao_a_Objetos.Contas;
using ByteBank___Estudo_Orientacao_a_Objetos.Titular;


//ContaCorrente contaDoAndre = new ContaCorrente();
//o . acessa as informações deste objeto
//contaDoAndre.titularNome = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();

//contaDaMaria.titularNome = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titularNome = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titularNome);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);

////contaDoAndre.Depositar(100);

////Console.WriteLine("Saldo da conta do André pós deposito = " + contaDoAndre.saldo);

////if (contaDoAndre.Sacar(300) == true)
////{
////    Console.WriteLine("Saldo da conta do André pós saque = " + contaDoAndre.saldo);
////}
////else
////{
////    Console.WriteLine("Saldo insuficiente para saque!");
////}
///
//Cliente cliente = new Cliente();
//cliente.nome = "Yago Borges";
//cliente.cpf = "363.348.968-14";
//cliente.profissao = "Programador C#";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular: "+conta.titular.nome);
//Console.WriteLine("CPF: " + conta.titular.cpf);
//Console.WriteLine("Profissão: " + conta.titular.profissao);
//Console.WriteLine("Conta: " + conta.conta);
//Console.WriteLine("Nº Agencia: " + conta.numero_agencia);
//Console.WriteLine("Saldo: " + conta.saldo);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "12345678914";
//conta2.conta = "1010-x";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

ContaCorrente conta3 = new ContaCorrente();
conta3.saldo = -10;
conta3.titular = new Cliente();


