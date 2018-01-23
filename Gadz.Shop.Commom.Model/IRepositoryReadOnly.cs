using System;
using System.Collections.Generic;

namespace Gadz.Shop.Commom.Model {
    public interface IRepositoryReadOnly<T> where T: IEntity {
        T Get(Identity id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> criteria);
    }
}
