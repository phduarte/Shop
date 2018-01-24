using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.Billing.Model.Faturas {
    public class Fatura : Entity {

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public Identity FuncionarioId { get; set; }
        public Identity FornecedorId { get; set; }

        public Fatura() {

        }

        public Fatura(Identity id) : base(id) {

        }

        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
