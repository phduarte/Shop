using System;
using System.Collections.Generic;
using Gadz.Shop.Billing.DomainModel.Clientes;
using Gadz.Shop.Billing.DomainModel.Fornecedores;
using Gadz.Shop.Billing.DomainModel.Compras;
using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing {
    public class BillingServices : Singleton<BillingServices> {

        public ICompra PegarConta(Identity id) {
            throw new NotImplementedException();
        }

        public void SalvarPagamento(ICompra conta) {
            throw new NotImplementedException();
        }

        public IEnumerable<IFornecedor> ListarFornecedores() {
            throw new NotImplementedException();
        }

        public IEnumerable<ICliente> ListarClientes() {
            throw new NotImplementedException();
        }

        public ICompra PegarFatura(Identity id) {
            throw new NotImplementedException();
        }

        public ICliente PegarCliente(Identity id) {
            throw new NotImplementedException();
        }

        public void SalvarFatura(ICompra fatura) {
            throw new NotImplementedException();
        }
    }
}
