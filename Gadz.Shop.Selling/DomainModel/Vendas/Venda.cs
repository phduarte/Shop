using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.DomainModel.Clientes;
using Gadz.Shop.Selling.DomainModel.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Shop.Selling.DomainModel.Vendas {

    internal class Venda : Entity, IVenda {

        public IList<IProduto> Produtos { get; private set; }
        public decimal ValorTotal => Produtos.Sum(x => x.Preco);
        public ICliente Cliente { get; private set; }
        public StatusVenda Status { get; private set; }
        public decimal TotalPago { get; private set; }
        public decimal Troco => TotalPago > ValorTotal ? TotalPago - ValorTotal : 0;

        public Venda(ICliente cliente) {
            Cliente = cliente;
            Produtos = new List<IProduto>();
            Status = StatusVenda.EM_ANDAMENTO;
        }

        public void Add(IProduto produto) {
            Produtos.Add(produto);
        }

        public void Remove(Identity id) {
            Produtos.Remove(Produtos.First(x => x.Id.Equals(id)));
        }

        public void AlterarCliente(ICliente cliente) {
            Cliente = cliente;
        }

        public void Finalizar() {
            Status = StatusVenda.AGUARDANDO_PAGAMENTO;
        }

        public void Pagar(decimal valor) {

            if(valor < 0) {
                throw new ArgumentException();
            }

            if (Status != StatusVenda.AGUARDANDO_PAGAMENTO) {
                throw new Exception("Finalize primeiro a venda");
            }

            ValidarPagamento();

            TotalPago += valor;
        }

        public void Estornar(decimal valor) {

            if (Status != StatusVenda.AGUARDANDO_PAGAMENTO) {
                throw new Exception("Não é possível estornar valores de venda incompleta ou finalizada");
            }

            if (valor < 0) {
                throw new ArgumentException();
            }

            TotalPago -= valor;

            ValidarPagamento();
        }

        private void ValidarPagamento() {
            if (TotalPago == ValorTotal) {
                Status = StatusVenda.AGUARDANDO_RETIRADA;
            }
        }

        public override string ToString() {
            return ValorTotal.ToString();
        }
    }
}
