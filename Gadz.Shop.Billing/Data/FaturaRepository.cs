using Gadz.Shop.Billing.Model.Faturas;
using Gadz.Shop.Commom.Model;
using System;
using System.Collections.Generic;

namespace Gadz.Shop.Billing.Data {
    public class FaturaRepository : IFaturaRepository {
        public void Add(Fatura entity) {
            //  string sql;

            //  sql = "exec sp_contas_pagar "
            //+ "@id_fornecedor = '" + this.cmbFornecedor.SelectedValue.ToString() + "',"
            //+ "@id_funcionario = '" + user.ID.ToString() + "',"
            //+ "@dt_pagamento = '" + this.dtPagamento.Value.ToShortDateString() + "',"
            //+ "@valor = '" + this.txtValor.Text + "',"
            //+ "@desc_pagamento = '" + this.txtDescricao.Text + "'";

            //  if (conn.ExecuteNonQuery(sql))
            //      MessageBox.Show(null, "Conta cadastrada com sucesso.", Program.Name);
            //  else
            //      MessageBox.Show(null, "Erro ao cadastrar conta.", Program.Name);
        }

        public IEnumerable<Fatura> GetAll() {
            throw new NotImplementedException();
        }

        public IEnumerable<Fatura> Find(Func<Fatura, bool> criterio) {
            throw new NotImplementedException();
        }

        public Fatura Get(Identity id) {
            throw new NotImplementedException();
        }

        public void Remove(Identity id) {
            throw new NotImplementedException();
        }

        public void Save(Fatura entity) {

            //  string sql;

            //  sql = "exec sp_contas_pagar "
            //+ "@id_fornecedor = '" + this.cmbFornecedor.SelectedValue.ToString() + "',"
            //+ "@id_funcionario = '" + user.ID.ToString() + "',"
            //+ "@dt_pagamento = '" + this.dtPagamento.Value.ToShortDateString() + "',"
            //+ "@valor = '" + this.txtValor.Text + "',"
            //+ "@desc_pagamento = '" + this.txtDescricao.Text + "'";

            //  if (conn.ExecuteNonQuery(sql))
            //      MessageBox.Show(null, "Conta cadastrada com sucesso.", Program.Name);
            //  else
            //      MessageBox.Show(null, "Erro ao cadastrar conta.", Program.Name);

        }
    }
}
