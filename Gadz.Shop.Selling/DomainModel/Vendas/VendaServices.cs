using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.Data;
using Gadz.Shop.Selling.DomainModel.Clientes;

namespace Gadz.Shop.Selling.DomainModel.Vendas {

    internal class VendaServices {

        readonly IVendaRepository _vendaRepository;

        public VendaServices() {
            _vendaRepository = new VendaRepository();
        }
        
        public IVenda Criar(ICliente cliente) {
            var novaVenda = new Venda(cliente);
            _vendaRepository.Add(novaVenda);
            return novaVenda;
        }

        public IVenda Buscar(Identity id) {
            return _vendaRepository.Get(id);
        }
        
        public void Salvar(IVenda venda) {
            _vendaRepository.Save(venda);
        }
    }
}
