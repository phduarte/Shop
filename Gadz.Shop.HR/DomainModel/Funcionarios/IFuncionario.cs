using Gadz.Shop.Commom.Model;
using Gadz.Shop.HR.DomainModel.Salarios;
using Gadz.Shop.HR.DomainModel.Situacoes;
using System;
using System.Collections.Generic;

namespace Gadz.Shop.HR.DomainModel.Funcionarios {
    public interface IFuncionario : IEntity {
        Nome Nome { get; }
        Cpf Cpf { get; }
        DateTime DataContratacao { get; }
        ISituacao Situacao { get; }
        ISalario Salario { get; }
        IList<ISalario> HistoricoSalarios { get; }
        IList<ISituacao> HistoricoSituacoes { get; }
        IList<Telefone> Telefones { get; }
        string Cargo { get; }

        void AlterarSalario(ISalario salario);
    }
}
