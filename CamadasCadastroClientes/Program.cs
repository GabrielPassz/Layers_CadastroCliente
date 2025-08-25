using CamadasCadastroClientes.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadasCadastroClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClienteService service = new ClienteService();
            int opcao;

            do
            {
                // Exibe o menu principal.
                Console.WriteLine("|========== Sistema de Cliente ==========|");
                Console.WriteLine("1 - Cadastra Cliente");
                Console.WriteLine("2 - Listar Cliente");
                Console.WriteLine("3 - Remover Cliente");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma Opção: ");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Digite o nome do Cliente: ");
                    string nome = Console.ReadLine();
                    try
                    {
                        service.CadastraCliente(nome);
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}\n");
                    }
                }
                else if (opcao == 2)
                {
                    //lista completa de clientes.
                    Console.WriteLine("|========== Lista de Clientes ==========|");
                    foreach (var c in service.ObeterCliente())
                    {
                        Console.WriteLine(c);
                    }
                }
                else if (opcao == 3)
                {                   
                    string nome;
                    Console.WriteLine("|========== Lista de Clientes ==========|");
                    foreach (var c in service.ObeterCliente())
                    {
                        Console.WriteLine(c);
                    }
                    
                    // Remoção de clientes.
                    Console.Write("Digite o nome que deseja remover: ");
                    nome = Console.ReadLine();
                    service.RemoverCliente(nome);
                    
                    //Lista atualizada após a remoção.
                    Console.WriteLine("|========== Lista de Clientes ==========|");
                    foreach (var c in service.ObeterCliente())
                    {
                        Console.WriteLine(c);
                    }
                }
            } while (opcao != 0);
            
            // Mensagem final ao encerrar.
            Console.WriteLine("Encerrando o sistema........");
        }
    }
}
