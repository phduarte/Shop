using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Selling {
    public static class By {
        public static Nome Nome(string nome) {
            return new Nome(nome);
        }

        public static Cpf Cpf(string cpf) {
            return new Cpf(cpf);
        }
    }
}
