using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.Data;
using System.Collections.Generic;

namespace Gadz.Shop.Selling.DomainModel.Clientes {
    internal class ClienteServices {

        readonly IClienteRepository _repository;

        public ClienteServices() {
            _repository = new ClienteRepository();
        }

        ICliente PegarCliente(Nome nome) {

            var cliente = _repository.First(x => x.Nome.Equals(nome));

            if (cliente == null) {
                return new Cliente(nome, string.Empty);
            }

            return cliente;

        }

        ICliente PegarCliente(Cpf cpf) {

            var cliente = _repository.First(x => x.Cpf.Equals(cpf));

            if(cliente == null) {
                return new Cliente(string.Empty, cpf);
            }

            return cliente;
        }

        public ICliente PegarCliente(dynamic by) {
            if (by is Nome) {
                return PegarCliente((Nome)by);
            }

            if (by is Cpf) {
                return PegarCliente((Cpf)by);
            }

            return null;
        }

        IEnumerable<ICliente> ProcurarClientes(Nome nome) {
            yield return new Cliente(nome, string.Empty);
        }

        IEnumerable<ICliente> ProcurarClientes(Cpf cpf) {
            yield return new Cliente(string.Empty, cpf);
        }

        public IEnumerable<ICliente> ProcurarClientes(dynamic pelo) {

            if (pelo is Nome) {
                return ProcurarClientes((Nome)pelo);
            }

            if (pelo is Cpf) {
                return ProcurarClientes((Cpf)pelo);
            }

            return null;
        }
    }
}
