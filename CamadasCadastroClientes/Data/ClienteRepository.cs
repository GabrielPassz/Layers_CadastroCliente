using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadasCadastroClientes.Data
{
    internal class ClienteRepository
    {
        // Armazena temporariamente os nomes dos clientes cadastrados em memória
        private List<string> cliente = new List<string>();
        
        // Adicionar um novo Cliente a Lista.
        public void Adicionar(string nome)
        {
            cliente.Add(nome);
        }
        // Remove um Cliente existente da Lista.
        public void Remover(string nome)
        {
            cliente.Remove(nome);
        }
        //  Retorna todos os clientes cadastrados no repositório.
        public List<string> Listar()
        {
            return cliente;
        }
    }
}
