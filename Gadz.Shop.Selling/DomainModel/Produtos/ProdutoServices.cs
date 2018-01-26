using Gadz.Shop.Selling.Data;

namespace Gadz.Shop.Selling.DomainModel.Produtos {

    internal class ProdutoServices {

        readonly IProdutoRepository _produtoRepository;

        public ProdutoServices() {
            _produtoRepository = new ProdutoRepository();
        }

        public IProduto PegarProdutoPorSku(string sku) {
            return _produtoRepository.FirstOrDefault(x => x.Sku.Equals(sku));
        }
    }
}
