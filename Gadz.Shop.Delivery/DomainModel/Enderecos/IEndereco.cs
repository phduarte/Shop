using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Delivery.DomainModel.Enderecos {
    public interface IEndereco : IEntity {
        string Logradouro { get; }
        string Bairro { get;  }
        string Cidade { get; }
        string Uf { get; }
        string Cep { get; }
        string Numero { get; }
        string Complemento { get; }
        float Distancia { get; }
    }
}
