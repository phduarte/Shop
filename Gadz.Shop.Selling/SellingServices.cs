using System.Collections.Generic;
using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.DomainModel.Clientes;
using Gadz.Shop.Selling.DomainModel.Produtos;
using Gadz.Shop.Selling.DomainModel.Vendas;

namespace Gadz.Shop.Selling {

    public class SellingServices : Singleton<SellingServices> {

        readonly VendaServices _vendaServices;
        readonly ClienteServices _clienteServices;
        readonly ProdutoServices _produtoServices;

        public SellingServices() {
            _vendaServices = new VendaServices();
            _clienteServices = new ClienteServices();
            _produtoServices = new ProdutoServices();
        }

        public IVenda BuscarVenda(string id_venda) {
            return _vendaServices.Buscar(id_venda);
        }

        public IProduto PegarProdutoPorSku(string sku) {
            return _produtoServices.PegarProdutoPorSku(sku);
        }

        public IVenda CriarNovaVenda(ICliente cliente) {
            return _vendaServices.Criar(cliente);
        }

        public ICliente PegarCliente(dynamic nome) {
            return _clienteServices.PegarCliente(nome);
        }

        public void SalvarVenda(IVenda venda) {
            _vendaServices.Salvar(venda);
        }

        public IEnumerable<ICliente> ProcurarClientes(dynamic nome) {
            return _clienteServices.ProcurarClientes(nome);
        }

        public void FinalizarVenda(IVenda venda) {
            venda.Finalizar();
            _vendaServices.Salvar(venda);
        }
    }
}
