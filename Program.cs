using System.Text.RegularExpressions;
using BackEndProj.Classes;

// métodos dos objetos - Genéricos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();

// **************************** CADASTRO ****************************
//endereço de pessoa física
Endereco endPf = new Endereco();
    endPf.logradouro = "Rua de Casa";
    endPf.numero = 123;
    endPf.comercial = false;
//pessoa física
PessoaFisica novaPessoaFisica = new PessoaFisica();
    Console.WriteLine($"Digite o nome:");
    novaPessoaFisica.nome = Console.ReadLine();
    novaPessoaFisica.dataNacimento = "20/07/1982";
    novaPessoaFisica.endereco = endPf;
    novaPessoaFisica.rendimento = 1600;
    novaPessoaFisica.cpf = "12345678-00";

//endereço de pessoa jurídica
Endereco endPj = new Endereco();
    endPj.logradouro = "Rua Niterói";
    endPj.numero = 180;
    endPj.comercial = true;

PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
    novaPessoaJuridica.nome = "Paulo Skaf";
    novaPessoaJuridica.endereco = endPj;
    novaPessoaJuridica.razaoSocial = "Serviço Nacional de Aprendizagem Industrial";
    // novaPessoaJuridica.cnpj = "73.339.078/0001-09";
    novaPessoaJuridica.cnpj = "73339078000109";
    novaPessoaJuridica.rendimento = 6000;

// **************************** EXIBIÇÃO ****************************

Console.Clear();

//Exibindo os dados da pessoa física
Console.WriteLine($"******** PESSOA FÍSICA ********");
Console.WriteLine();

Console.WriteLine(@$"
Nome: {novaPessoaFisica.nome}
Endereço: {novaPessoaFisica.endereco.logradouro}
Número: {novaPessoaFisica.endereco.numero}
Endereço Comercial: {novaPessoaFisica.endereco.comercial}
CPF: {novaPessoaFisica.cpf}
Data Nascimento: {novaPessoaFisica.dataNacimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(novaPessoaFisica.dataNacimento)}
Rendimento: R$ {novaPessoaFisica.rendimento}
Rendimento Líquido: R$ {metodosPf.PagarImposto(novaPessoaFisica.rendimento)}
");

Console.WriteLine();
Console.WriteLine($"******** PESSOA JURÍDICA ********");
Console.WriteLine();

//Exibindo os dados da pessoa jurídica
Console.WriteLine($"Razão Social: {novaPessoaJuridica.razaoSocial}");
Console.WriteLine($"CNPJ: {novaPessoaJuridica.cnpj}");
Console.WriteLine($"Representante: {novaPessoaJuridica.nome}");
Console.WriteLine($"Endereço: {novaPessoaJuridica.endereco.logradouro}");
Console.WriteLine($"Número: {novaPessoaJuridica.endereco.numero}");
Console.WriteLine($"Endereço Comercial: {novaPessoaJuridica.endereco.comercial}");
Console.WriteLine($"CNPJ Válido? {metodosPj.ValidarCnpj(novaPessoaJuridica.cnpj)}");
Console.WriteLine($"Rendimento: R$ {novaPessoaJuridica.rendimento}");
Console.WriteLine($"Imposto Líquido: R$ {metodosPj.PagarImposto(novaPessoaJuridica.rendimento)}");//cálculo do desconto






//************************** TESTES DE APRENDIZADO *****************************

// ************************** SUBSTRING *****************************
// //             0123456789...
// string nome = "Eduardo Costa Silva Sulo Roberto";

// Console.WriteLine(nome.Length);
// Console.WriteLine(nome.Substring(7));
// Console.WriteLine(nome.Substring(0, 6));

// Console.WriteLine(nome.IndexOf("Costa"));

// Console.WriteLine(@$"
//     Nome completo: {nome}
//     Sobrenome: {nome.Substring(nome.IndexOf("Costa"))}
// ");


// ************************** REGEX *****************************
// string data = "26-10-2022";
// bool dataVAlida = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// bool dataVAlida2 = Regex.IsMatch(data, @"^\d{2}-\d{2}-\d{4}$");

// Console.WriteLine(dataVAlida);
// Console.WriteLine(dataVAlida2);


