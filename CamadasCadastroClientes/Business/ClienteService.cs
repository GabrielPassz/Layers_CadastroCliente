using CamadasCadastroClientes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadasCadastroClientes.Business
{
    internal class ClienteService
    {
        private ClienteRepository _repository = new ClienteRepository();

        // Realiza o cadastro de um cliente, não permitindo nome vazio ou nulo.
        public void CadastraCliente(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new System.Exception("O nome não pode ser vazio");

            _repository.Adicionar(nome);
        }
        // Remove um cliente existente, não permitindo nome vazio ou nulo.  
        public void RemoverCliente(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new System.Exception("O nome não pode ser vazio");
            _repository.Remover(nome);
        }
        // Retorna a lista de clientes cadastrados.

        public List<string> ObeterCliente()
        {
            return _repository.Listar();
        }
    }
}
