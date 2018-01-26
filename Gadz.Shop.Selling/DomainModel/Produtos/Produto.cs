using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Selling.DomainModel.Produtos {

    internal class Produto : Entity, IProduto {

        public string Sku { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; private set; }
        public decimal SubTotal => Preco * Quantidade;
        public string Imagem { get; set; }
        public int Estoque { get; set; }

        public Produto() {
            Adicionar();
        }

        public Produto(Identity id) : base(id) {
            Adicionar();
        }

        public void Adicionar() {
            Quantidade++;
        }

        public void Adicionar(int quantidade) {
            Quantidade += quantidade;
        }

        public void Remover() {
            Quantidade--;
        }

        public void Remover(int quantidade) {
            Quantidade -= quantidade;
        }

        public static Produto Vazio() {
            return new Produto();
        }

        public override string ToString() {
            return Nome;
        }
    }
}
