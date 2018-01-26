using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.HR.DomainModel.Situacoes {
    public interface ISituacao : IEntity {
        Nome Nome { get; }
        Status Status { get; }
        DateTime Desde { get; }
        DateTime Ate { get; }
        bool Custo { get; }
    }
}
