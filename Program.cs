using BackEndProj.Classes;


PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = "Eduardo Costa";
novaPessoaFisica.endereco = "Rua de Casa, 123";
novaPessoaFisica.rendimento = 1000f;
novaPessoaFisica.cpf = "12345678-00";

Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
Console.WriteLine($"Endereço: {novaPessoaFisica.endereco}");
Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
Console.WriteLine($"Rendimento: {novaPessoaFisica.rendimento}");
