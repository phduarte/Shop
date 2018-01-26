using System;

namespace Gadz.Shop.Commom.Model {
    public struct Identity {

        string _id;

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

        public static implicit operator Identity(string id) {
            return new Identity(id);
        }

        public static implicit operator string(Identity id) {
            return id.ToString();
        }

        public override bool Equals(object obj) {

            if(obj is Identity i) {
                return _id.Equals(i.ToString());
            }

            return false;
        }

        public override int GetHashCode() {
            return _id.GetHashCode();
        }

        public static Identity New() {
            return new Identity(Guid.NewGuid().ToString());
        }

        public bool Empty => string.IsNullOrWhiteSpace(_id);
    }
}
