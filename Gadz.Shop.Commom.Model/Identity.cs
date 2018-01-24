using System;

namespace Gadz.Shop.Commom.Model {
    public class Identity {

        string _id = string.Empty;

        private Identity() {

        }

        public Identity(string id) {
            _id = id;
        }

        public override string ToString() {
            return _id;
        }

        public static implicit operator Identity(int id) {
            return new Identity(id.ToString());
        }

        public static implicit operator int(Identity id) {
            return int.Parse(id.ToString());
        }

        public static Identity New() {
            return new Identity(Guid.NewGuid().ToString());
        }

    }
}
