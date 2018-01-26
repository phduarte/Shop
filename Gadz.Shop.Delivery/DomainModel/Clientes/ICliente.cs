using Gadz.Shop.Commom.Model;
using Gadz.Shop.Delivery.DomainModel.Enderecos;
using System.Collections.Generic;

namespace Gadz.Shop.Delivery.DomainModel.Clientes {

    public interface ICliente : IEntity {

        Nome Nome { get; }
        Cpf Cpf { get; }
        IEndereco Endereco { get; }
        IList<Telefone> Telefones { get; }

        void AdicionarTelefone(Telefone telefone);
        void RemoverTelefone(Telefone telefone);
    }
}
