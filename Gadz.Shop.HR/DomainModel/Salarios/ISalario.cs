using Gadz.Shop.Commom.Model;
using System;
using System.Collections.Generic;

namespace Gadz.Shop.HR.DomainModel.Salarios {
    public interface ISalario : IEntity {
        decimal Valor { get; }
        DateTime DataInicio { get; }
        decimal CustoHora { get; }
        IList<Desconto> Descontos { get; }
        decimal FaixaIRRF { get; }
        decimal BaseIRRF { get; }
    }
}
