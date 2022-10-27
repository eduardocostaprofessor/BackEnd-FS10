using System.Text.RegularExpressions;
using BackEndProj.Classes;


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






// //endereço de pessoa física
// Endereco endPf = new Endereco();
//     endPf.logradouro = "Rua de Casa";
//     endPf.numero = 123;
//     endPf.comercial = false;

// //pessoa física
// PessoaFisica novaPessoaFisica = new PessoaFisica();

//     novaPessoaFisica.nome = "Eduardo Costa";
//     novaPessoaFisica.endereco = endPf;
//     novaPessoaFisica.rendimento = 1000f;
//     novaPessoaFisica.cpf = "12345678-00";



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
    novaPessoaJuridica.rendimento = 100000f;
    
    Console.WriteLine($"CNPJ VÁLIDO? {novaPessoaJuridica.ValidarCnpj(novaPessoaJuridica.cnpj)}");
    



// Console.Clear();

// //Exibindo os dados da pessoa física
// Console.WriteLine($"******** PESSOA FÍSICA ********");
// Console.WriteLine();

// Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
// Console.WriteLine($"Endereço: {novaPessoaFisica.endereco.logradouro}");
// Console.WriteLine($"Número: {novaPessoaFisica.endereco.numero}");
// Console.WriteLine($"Endereço Comercial: {novaPessoaFisica.endereco.comercial}");
// Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.rendimento}");
// Console.WriteLine("Maior de Idade: " + novaPessoaFisica.ValidarDataNascimento("1982,07,20"));


// Console.WriteLine("Maior de Idade: " + novaPessoaFisica.ValidarDataNascimento("20/07/1982"));



// Console.WriteLine($"******** PESSOA JURÍDICA ********");
// Console.WriteLine();

// //Exibindo os dados da pessoa jurídica
// Console.WriteLine($"Razão Social: {novaPessoaJuridica.razaoSocial}");
// Console.WriteLine($"CNPJ: {novaPessoaJuridica.cnpj}");
// Console.WriteLine($"Representante: {novaPessoaJuridica.nome}");
// Console.WriteLine($"Endereço: {novaPessoaJuridica.endereco.logradouro}");
// Console.WriteLine($"Número: {novaPessoaJuridica.endereco.numero}");
// Console.WriteLine($"Endereço Comercial: {novaPessoaJuridica.endereco.comercial}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaJuridica.rendimento}");



