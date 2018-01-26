using Gadz.Shop.Commom.Model;
using Gadz.Shop.Delivery.DomainModel.Enderecos;
using System.Collections.Generic;

namespace Gadz.Shop.Delivery.DomainModel.Clientes {
    internal class Cliente : Entity, ICliente {

        public Nome Nome { get; private set; }

        public Cpf Cpf { get; private set; }

        public IEndereco Endereco { get; private set; }

        public IList<Telefone> Telefones { get; private set; }

        public Cliente() {
            Telefones = new List<Telefone>();
        }

        public Cliente(string nome, string endereco, string telefone) : this() {
            Nome = nome;
            Endereco = new Endereco(endereco);
            Telefones.Add(new Telefone(telefone));
        }


        public void AdicionarTelefone(Telefone telefone) {
            Telefones.Add(telefone);
        }

        public void RemoverTelefone(Telefone telefone) {
            Telefones.Remove(telefone);
        }
    }
}
