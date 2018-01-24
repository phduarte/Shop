namespace Gadz.Shop.Commom.Model {
    public abstract class Entity : IEntity {

        public Identity Id { get; private set; }
        public bool Exists { get; private set; }

        protected Entity(Identity id) {
            Id = id;
            Exists = true;
        }

        protected Entity() {
            Id = Identity.New();
            Exists = false;
        }
    }
}
