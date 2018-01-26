using Gadz.Shop.Commom.Model;
using Gadz.Shop.HR.DomainModel.Funcionarios;
using System;

namespace Gadz.Shop.HR.DomainModel.Holerites {
    public interface IHolerite : IEntity {
        IFuncionario Funcionario { get; }
        string Empresa { get; }
        DateTime De { get;  }
        DateTime Ate { get; }
        string Referencia { get; }
        decimal Vencimentos { get; }
        decimal Descontos { get; }
        decimal ValorLiquido { get; }
    }
}
