using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.Selling.DomainModel.Clientes {
    internal interface IClienteRepository : IRepository<ICliente> {
        ICliente First(Func<ICliente, bool> criterio);
    }
}
