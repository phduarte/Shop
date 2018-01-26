using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.DomainModel.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Shop.Selling.Data {
    internal class ClienteRepository : IClienteRepository {

        static IList<ICliente> _cache = new List<ICliente> {
            new Cliente("Paulo Henrique Fernandes Duarte", "08413329671"),
            new Cliente("Anônimo", "00000000000"),
            new Cliente("Anônimo", "11111111111"),
            new Cliente("Anônimo", "22222222222"),
            new Cliente("Anônimo", "33333333333")
        };

        public void Add(ICliente entity) {
            _cache.Add(entity);
        }

        public IEnumerable<ICliente> Find(Func<ICliente, bool> criteria) {
            return _cache.Where(criteria);
        }

        public ICliente First(Func<ICliente, bool> criterio) {
            return Find(criterio).First();
        }

        public ICliente Get(Identity id) {
            return _cache.First(x => x.Id.Equals(id));
        }

        public IEnumerable<ICliente> GetAll() {
            return _cache;
        }

        public void Remove(Identity id) {
            _cache.Remove(Get(id));
        }

        public void Save(ICliente entity) {
            var c = Get(entity.Id);
            c = entity;
        }
    }
}
