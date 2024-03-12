using System;
using System.Globalization;
using aula3Colecao.Models.Enuns;
using aula3Colecao.Models;
using System.Security.Cryptography.X509Certificates;

namespace aula3Colecao
{

class Program
    {
      
    static List<Funcionario> lista = new List<Funcionario>();

        static void Main(string[] args)
        {
            ExemplosListasColecoes();
        }
    public static void CriarLista()
    {
        Funcionario f1 = new Funcionario();
        f1.Id = 1;
        f1.Nome = "Neymar";
        f1.Cpf = "19453517877";
        f1.DataAdmissao = DateTime.Parse("01/01/2002");
        f1.Salario = 100.000M;
        f1.TipoFuncionario = TipoFuncionarioEnum.CLT;
        lista.Add(f1);   

        Funcionario f2  = new Funcionario();
        f2.Id = 2; 
       f2.Nome = "Cristiano Ronaldo"; 
       f2.Cpf = "01987654321";
       f2.DataAdmissao = DateTime.Parse("30/06/2002"); 
       f2.Salario = 150.000M; 
       f2.TipoFuncionario = TipoFuncionarioEnum.CLT; 
       lista.Add(f2);    

       Funcionario f3 = new Funcionario();
       f3.Id = 3;
       f3.Nome = "Messi";
       f3.Cpf = "135792468"; 
       f3.DataAdmissao = DateTime.Parse("01/11/2003"); 
       f3.Salario = 70.000M; 
       f3.TipoFuncionario = TipoFuncionarioEnum.Aprendiz; 
       lista.Add(f3); 

       Funcionario f4 = new Funcionario();
       f4.Id = 4; 
       f4.Nome = "Mbappe"; 
       f4.Cpf = "246813579";
       f4.DataAdmissao = DateTime.Parse("15/09/2005"); 
       f4.Salario = 100.000M;
       f4.TipoFuncionario = TipoFuncionarioEnum.Aprendiz; 
       lista.Add(f4); 

       Funcionario f5= new Funcionario();
       f5.Id = 5; 
       f5.Nome = "Lewa";
       f5.Cpf = "246813579"; 
       f5.DataAdmissao = DateTime.Parse("20/10/1998"); 
       f5.Salario = 90.000M; 
       f5.TipoFuncionario = TipoFuncionarioEnum.Aprendiz; 
       lista.Add(f5);

       Funcionario f6 =  new Funcionario();
       f6.Id = 6; 
       f6.Nome = "Rodrigo Garro"; 
       f6.Cpf = "246810579"; 
       f6.DataAdmissao = DateTime.Parse("13/12/1997"); 
       f6.Salario = 300.000M; 
       f6.TipoFuncionario = TipoFuncionarioEnum.CLT; 
       lista.Add(f6); 

    }
      public static void ExibirLista()
    {
        string dados = "";
        for (int i = 0; i < lista.Count; i++)
        {
            dados += "=================== \n";
            dados += string.Format("Id: {0} \n", lista[i].Id);
            dados += string.Format("Nome: {0} \n", lista[i].Nome);
            dados += string.Format("CPF: {0} \n", lista[i].Cpf);
            dados += string.Format("Admissão: {0:dd/MM/yyyy} \n", lista[i].DataAdmissao);
            dados += string.Format("Salário: {0:c2} \n", lista[i].Salario);
            dados += string.Format("Tipo: {0} \n", lista[i].TipoFuncionario);
        }
        Console.WriteLine(dados);
    }

    public static void ObterLista()
    {
        
        lista = lista.FindAll(x => x.Id == x.Id);
        ExibirLista();
    }
    public static void ExemplosListasColecoes() 
    {
        Console.WriteLine("=================================================="); 
        Console.WriteLine("****** Exemplos - Aula 03 Listas e Coleções ******"); 
        Console.WriteLine("=================================================="); 
        CriarLista();
        int opcaoEscolhida = 0;
        do 
        {
            Console.WriteLine("=================================================="); 
            Console.WriteLine("---Digite o número referente a opção desejada: ---"); 
            Console.WriteLine("1 - Obter Por Id");  
            Console.WriteLine("2 - Adicionar Funcionário");  
            Console.WriteLine("3 - Obter Por Id Digitado");  
            Console.WriteLine("4 - Obter Por Salário Digitado");  
            Console.WriteLine("5 - Contagem de funcionários"); 
            Console.WriteLine("6 - Soma De Salários"); 
            Console.WriteLine("7 - Remover Id's menores que 4"); 
            Console.WriteLine("8 - Contagem de funcionários e Total de salário"); 
            Console.WriteLine("9 - Buscar por nome");
            Console.WriteLine("=================================================="); 
            Console.WriteLine("-----Ou tecle qualquer outro número para sair-----"); 
            Console.WriteLine("==================================================");    

            opcaoEscolhida=int.Parse(Console.ReadLine()); 
            string mensagem=string.Empty; 
            switch(opcaoEscolhida)
            {
                case 1:
                    ObterLista();
                    break;
                case 2:
                     AdicionarFuncionario();       
                     break;
                case 3:
                    Console.WriteLine("Digite o Id do funcionado que voce deseja buscar: ");
                    int id = int.Parse(Console.ReadLine());
                    ObterPorId(id);  
                    break; 
                case 4:
                    Console.WriteLine("Digite o valor do salário para obter todos os valores acima do indicado");
                    decimal salario = decimal.Parse(Console.ReadLine());
                    ObterPorSalario(salario);
                    break; 
                case 5:
                    ContarFuncionarios();
                    break;
                case 6:
                        SomarSalarios();
                        break;  
                case 7:
                        ObterFuncionariosRecentes();  
                        break;    
                case 8:
                        ObterEstatisticas();
                        break;    
                case 9:
                        
                        Console.WriteLine("Digite o nome do funcionado que voce deseja buscar: ");
                        string nome = Console.ReadLine();
                        BuscarPorNome(nome);
                        break;              
                default:
                    Console.WriteLine("Saindo do sistema...");
                    break;    
            }
            }while (opcaoEscolhida >= 1 && opcaoEscolhida <= 4);
            Console.WriteLine("=================================================="); 
            Console.WriteLine("* Obrigado por utilizar o sistema e volte sempre *"); 
            Console.WriteLine("==================================================");    
            
        }
    public static void AdicionarFuncionario()
    {
        Funcionario f = new Funcionario();
        
        Console.WriteLine("Digite o nome: ");
        f.Nome = Console.ReadLine();

        Console.WriteLine("Digite o salário: ");
        f.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a data de admissão: ");
        f.DataAdmissao = DateTime.Parse(Console.ReadLine());

        if (string.IsNullOrEmpty(f.Nome))
        {
            Console.WriteLine("O nome tem que ser prenchido!!");
            return;
        }
        else if(f.Salario == 0)
        {
            Console.WriteLine("O valor do salário não pde ser 0.");
            return;
        }
        else
        {
            lista.Add(f);
            ExibirLista();
        }
    }


    public static void ObterPorId(int id){
        Funcionario fBusca = lista.Find(x => x.Id == id);

        Console.WriteLine($"Personagem Encontrado: {fBusca.Nome}");
    }

    public static void ObterPorSalario(decimal valor)
    {
        lista = lista.FindAll(x => x.Salario >= valor);
        ExibirLista();
    }

    public static void ContarFuncionarios()
    {
        int qtd = lista.Count();
        Console.WriteLine ($"Existe {qtd} Funcionários.");
    }

    public static void SomarSalarios()
    {
        decimal somatorio = lista.Sum(x=> x.Salario);
        Console.WriteLine(string.Format("A soma dos salários é {0:c2} ", somatorio));
    }

   public static void ObterFuncionariosRecentes()
   {
    lista.RemoveAll(x => x.Id < 4);
    var Ordenada=  lista.OrderByDescending(x => x.Salario).ToList();
        ExibirLista();
   }

    public static void ObterEstatisticas(){
        int qtd = lista.Count();
        Console.WriteLine ($"Existe {qtd} Funcionários.");
        decimal somatorio = lista.Sum(x=> x.Salario);
        Console.WriteLine(string.Format("A soma dos salários é {0:c2} ", somatorio));
    }

    public static void BuscarPorNome(string nome){
       Funcionario fBusca  = lista.Find(x => x.Nome == nome);

        if ( nome == nome){
            Console.WriteLine($"Personagem Encontrado: {fBusca.Nome}");
           
        }
        else
        {
         Console.WriteLine("Nome não encontrado");
            return;
        }
        

    }
    }


    }

