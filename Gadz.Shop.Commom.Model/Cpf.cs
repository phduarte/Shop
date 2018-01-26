namespace Gadz.Shop.Commom.Model {

    public struct Cpf {

        private string _cpf;
        public bool IsValid { get { return _cpf.Length == 11; } }

        public Cpf(string cpf) {
            _cpf = cpf;
        }

        public static implicit operator Cpf(string cpf) {
            return new Cpf(cpf);
        }

        public static   implicit operator string(Cpf cpf) {
            return cpf.ToString();
        }

        public override string ToString() {
            return _cpf;
        }
    }
}