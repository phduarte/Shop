using Gadz.Shop.Billing.DomainModel.Clientes;
using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.Billing.Model.Faturas {
    internal class Fatura : Entity, IFatura {

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public Identity FuncionarioId { get; set; }
        public Identity FornecedorId { get; set; }
        decimal IFatura.Valor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICliente Cliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DataRecebimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
