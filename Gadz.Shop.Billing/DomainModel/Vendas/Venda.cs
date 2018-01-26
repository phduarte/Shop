using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.Billing.Model.Vendas {
    internal class Venda : Entity, IVenda {

        public string Anotacoes { get; internal set; }
        public double Valor { get; internal set; }
        public DateTime DataPagamento { get; internal set; }
        public DateTime DataVencimento { get; internal set; }
        public Identity BeneficiarioId { get; internal set; }

        public Venda() {
            
        }

        public Venda(Identity id) : base(id) {
        }
    }
}
