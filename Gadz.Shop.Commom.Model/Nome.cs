namespace Gadz.Shop.Commom.Model {
    public struct Nome {

        private string _nome;

        public Nome(string nome) {
            _nome = nome;
        }

        public static implicit operator Nome(string nome) {
            return new Nome(nome);
        }

        public static implicit operator string(Nome nome) {
            return nome.ToString();
        }

        public override string ToString() {
            return _nome;
        }
    }
}