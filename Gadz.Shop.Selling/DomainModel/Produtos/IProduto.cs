using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Selling.DomainModel.Produtos {
    public interface IProduto : IEntity {
        string Descricao { get; set; }
        int Estoque { get; set; }
        string Imagem { get; set; }
        string Nome { get; set; }
        decimal Preco { get; set; }
        int Quantidade { get; }
        string Sku { get; set; }
        decimal SubTotal { get; }

        void Adicionar();
        void Adicionar(int quantidade);
        void Remover();
        void Remover(int quantidade);
    }
}