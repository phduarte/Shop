using Gadz.Shop.Commom.Model;
using Gadz.Shop.HR.DomainModel.Salarios;

namespace Gadz.Shop.HR.DomainModel.Cargos {
    public interface ICargo : IEntity {
        Nome Nome { get; }
        ISalario Salario { get; }
    }
}
