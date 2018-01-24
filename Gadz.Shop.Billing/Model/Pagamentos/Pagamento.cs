using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.Billing.Model.Pagamentos {
    public class Pagamento : Entity {

        public string Descricao { get; internal set; }
        public double Valor { get; internal set; }
        public DateTime DataPagamento { get; internal set; }
        public DateTime DataVencimento { get; internal set; }
        public Identity BeneficiarioId { get; internal set; }

        public Pagamento() {
            
        }

        public Pagamento(Identity id) : base(id) {
        }
    }
}
