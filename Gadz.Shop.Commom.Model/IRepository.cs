namespace Gadz.Shop.Commom.Model {
    public interface IRepository<T> : IRepositoryReadOnly<T> where T: IEntity {
        void Add(T entity);
        void Remove(Identity id);
        void Save(T entity);
    }
}
