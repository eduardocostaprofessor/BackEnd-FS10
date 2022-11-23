using System.Text.RegularExpressions;
using BackEndProj.Classes;


// Métodos genéricos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();

// Listas para persistência dos dados de PF e PJ
List<PessoaFisica> cadastroPf = new List<PessoaFisica>();//Lista (Array) de PessoaFisica
List<PessoaJuridica> cadastroPj = new List<PessoaJuridica>();//Lista (Array) de PessoaJurídica


//Cabeçalho boas vindas
Console.WriteLine(@$"
==================================================
|     Bem vindo ao sistema de cadastro de        |
|        Pessoas Físicas e Jurídicas             |
==================================================
");

Utils.BarraCarregamento("Iniciando o Sistema", 3, 500);


string opcao;

// ************ MENU PRINCIPAL ************ 
do
{
    Console.Clear();
    Console.WriteLine(@$"
==================================================
|         Escolha uma das seguintes opções       |
|------------------------------------------------|
|               1 - Pessoa Física                |
|               2 - Pessoa Jurídica              |
|                                                |
|               0 - Sair                         |
==================================================
");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();//espera o usuário digitar
    Console.Clear();

    switch (opcao)
    {

        case "1":   //Pessoa Física
            
            string opcaoPf;

            // ************ SUB-MENU PESSOA FÍSICA ************ 
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
==================================================
|         Escolha uma das seguintes opções       |
|------------------------------------------------|
|           1 - Cadastrar Pessoa Física          |
|           2 - Listar Pessoa Física             |
|                                                |
|           0 - Voltar ao menu anterior          |
==================================================
");

                Console.Write("Escolha uma opção:");
                opcaoPf = Console.ReadLine();


                switch (opcaoPf)
                {
                    case "1": // Cadastrar Pessoa Física
                        //endereço de pessoa física
                        Endereco endPf = new Endereco();
                        endPf.logradouro = "Rua de Casa";
                        endPf.numero = 123;
                        endPf.comercial = false;

                        //pessoa física
                        PessoaFisica novaPessoaFisica = new PessoaFisica();
                        // Console.WriteLine($"Digite o nome:");
                        novaPessoaFisica.nome = "Eduardo Costa";
                        novaPessoaFisica.dataNacimento = "20/07/1982";
                        novaPessoaFisica.endereco = endPf;
                        novaPessoaFisica.rendimento = 1600;
                        novaPessoaFisica.cpf = "12345678-00";

                        //cadastra na lista
                        cadastroPf.Add(novaPessoaFisica);
                        Utils.ParadaNoConsole("Cadastro Pessoa Física efetuado com sucesso");
                        break;

                    case "2": // Listar Pessoa Física
                        Console.WriteLine($"******** Listagem de Pessoas Físicas ********");
                        Console.WriteLine();
                        //ler cada pessoa da lista
                        foreach (var pf in cadastroPf)
                        {

                            Console.WriteLine(@$"
Nome: {pf.nome}
Endereço: {pf.endereco.logradouro}
Número: {pf.endereco.numero}
Endereço Comercial: {pf.endereco.comercial}
CPF: {pf.cpf}
Data Nascimento: {pf.dataNacimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(pf.dataNacimento)}
Rendimento: R$ {pf.rendimento}
Rendimento Líquido: R$ {metodosPf.PagarImposto(pf.rendimento)}
");
                        }

                        Utils.ParadaNoConsole("Fim da listagem");
                        break;

                    case "0": // Voltar ao menu principal
                        Utils.ParadaNoConsole("Opção escolhida é Voltar ao menu anterior");
                        break;

                    default:
                        Utils.ParadaNoConsole("Opção Inválida, pressione 'ENTER' para continuar");
                        break;
                }
            } while (opcaoPf != "0");



            // Parada no console
            Utils.ParadaNoConsole("Pressione 'ENTER' para continuar");//verificar se precisa retirar
            break;


        case "2":   //Pessoa Jurídica
            string opcaoPj;

            do
            {

                Console.Clear();
                Console.WriteLine(@$"
==================================================
|         Escolha uma das seguintes opções       |
|------------------------------------------------|
|           1 - Cadastrar Pessoa Jurídica        |
|           2 - Listar Pessoa Jurídica           |
|                                                |
|           0 - Voltar ao menu anterior          |
==================================================
");
                Console.Write("Escolha uma opção:");
                opcaoPj = Console.ReadLine();
                
                switch (opcaoPj)
                {

                    case "1": //Cadastrar Pessoa Jurídica
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

                        // Cadastra uma pessoa na lista
                        cadastroPj.Add(novaPessoaJuridica);

                        Utils.ParadaNoConsole("Pessoa Jurídica cadastrada com sucesso!");
                        break;

                    case "2": //Listar Pessoa Jurídica
                        Console.Clear();
                        Console.WriteLine($"******** Listagem de Pessoas Jurídicas ********");
                        Console.WriteLine();

                        //ler cada pessoa da lista
                        foreach (var pj in cadastroPj)
                        {
                            Console.WriteLine();
                            //Exibindo os dados da pessoa jurídica
                            Console.WriteLine($"Razão Social: {pj.razaoSocial}");
                            Console.WriteLine($"CNPJ: {pj.cnpj}");
                            Console.WriteLine($"Representante: {pj.nome}");
                            Console.WriteLine($"Endereço: {pj.endereco.logradouro}");
                            Console.WriteLine($"Número: {pj.endereco.numero}");
                            Console.WriteLine($"Endereço Comercial: {pj.endereco.comercial}");
                            Console.WriteLine($"CNPJ Válido? {metodosPj.ValidarCnpj(pj.cnpj)}");
                            Console.WriteLine($"Rendimento: R$ {pj.rendimento}");
                            Console.WriteLine($"Imposto Líquido: R$ {metodosPj.PagarImposto(pj.rendimento)}");//cálculo do desconto
                        }

                        Console.WriteLine();
                        Utils.ParadaNoConsole("Fim da listagem");

                        break;

                    case "0": // Voltar ao menu principal
                        Utils.ParadaNoConsole("Opção escolhida é Voltar ao menu anterior");
                        break;

                    default:
                        Utils.ParadaNoConsole("Opção Inválida, pressione");
                        break;

                }

            } while (opcaoPj != "0");









            // // **************************** EXIBIÇÃO ****************************

            // Parada no console
            Utils.ParadaNoConsole("Pressione 'ENTER' para continuar");
            break;

        case "0":   //Sair
            // Parada no console
            Console.Clear();
            Utils.ParadaNoConsole("Obrigado por utilizar o sistema, pressione 'ENTER' para finalizar");
            Utils.BarraCarregamento("Iniciando o Sistema", 3, 300);
            break;

        default:    //Qualquer outra opção
            Console.Clear();
            // Parada no console
            Utils.ParadaNoConsole("Opção Inválida 'ENTER' para continuar");
            break;
    }


} while (opcao != "0"); //enquanto não quiser sair




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


