using System;
using System.Collections.Generic;
using Gadz.Shop.Billing.DomainModel.Clientes;
using Gadz.Shop.Billing.DomainModel.Fornecedores;
using Gadz.Shop.Billing.Model.Faturas;
using Gadz.Shop.Billing.Model.Pagamentos;
using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing {
    public class BillingServices : Singleton<BillingServices> {

        public IPagamento PegarConta(Identity id) {
            throw new NotImplementedException();
        }

        public void SalvarPagamento(IPagamento conta) {
            throw new NotImplementedException();
        }

        public IEnumerable<IFornecedor> ListarFornecedores() {
            throw new NotImplementedException();
        }

        public IEnumerable<ICliente> ListarClientes() {
            throw new NotImplementedException();
        }

        public IFatura PegarFatura(Identity id) {
            throw new NotImplementedException();
        }

        public ICliente PegarCliente(Identity id) {
            throw new NotImplementedException();
        }

        public void SalvarFatura(IFatura fatura) {
            throw new NotImplementedException();
        }
    }
}
