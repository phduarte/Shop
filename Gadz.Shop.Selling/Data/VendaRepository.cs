using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.DomainModel.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Shop.Selling.Data {
    internal class VendaRepository : IVendaRepository {

        static IList<IVenda> _cache = new List<IVenda>();

        public void Add(IVenda entity) {
            _cache.Add(entity);
        }

        public IEnumerable<IVenda> Find(Func<IVenda, bool> criteria) {
            return _cache.Where(criteria);
        }

        public IVenda Get(Identity id) {
            return _cache.First(x => x.Id.Equals(id));
        }

        public IEnumerable<IVenda> GetAll() {
            return _cache;
        }

        public void Remove(Identity id) {
            _cache.Remove(Get(id));
        }

        public void Save(IVenda entity) {
            var x = Get(entity.Id);
            x = entity;
        }
    }
}
