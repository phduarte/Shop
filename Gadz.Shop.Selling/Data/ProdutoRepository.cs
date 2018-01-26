using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.DomainModel.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gadz.Shop.Selling.Data {
    internal class ProdutoRepository : IProdutoRepository {

        static IList<IProduto> _cache = LoadCache();

        public void Add(IProduto entity) {
            _cache.Add(entity);
        }

        public IEnumerable<IProduto> Find(Func<IProduto, bool> criteria) {
            return _cache.Where(criteria);
        }

        public IProduto FirstOrDefault(Func<IProduto, bool> criterio) {
            return Find(criterio).FirstOrDefault();
        }

        public IProduto Get(Identity id) {
            return _cache.First(x=>x.Id.Equals(id));
        }

        public IEnumerable<IProduto> GetAll() {
            return _cache;
        }

        public void Remove(Identity id) {
            _cache.Remove(Get(id));
        }

        public void Save(IProduto entity) {
            _cache[entity.Id] = entity;
        }

        private static IList<IProduto> LoadCache() {
            return new List<IProduto> {
                new Produto(Identity.New()) { Sku = "7898563932394", Nome = "Pilha Recarregável", Descricao = "Pilha Recarregável MOX AA 1.2v 2600 mhA", Preco = 20, Imagem = "" },
                new Produto(Identity.New()) { Sku = "7896603803796", Nome = "Fita Adesiva", Descricao = "Fita Adesiva QualiTape 520", Preco = 10, Imagem = "" }
            };
        }
    }
}
