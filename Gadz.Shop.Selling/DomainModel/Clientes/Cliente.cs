using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Selling.DomainModel.Clientes {
    internal class Cliente : Entity, ICliente {

        public Nome Nome { get; private set; }
        public Cpf Cpf { get; private set; }

        public Cliente(string nome, string cpf) {
            Nome = new Nome(nome);
            Cpf = new Cpf(cpf);
        }

        public override string ToString() {
            return Nome.ToString();
        }
    }
}
