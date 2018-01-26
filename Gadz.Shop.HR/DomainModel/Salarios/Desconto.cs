namespace Gadz.Shop.HR.DomainModel.Salarios {
    public class Desconto {
        public string Descricao { get; private set; }
        public decimal Referencia { get; private set; }
        public decimal Total { get; private set; }

        public Desconto(string descricao, decimal vencimentos) {
            Descricao = descricao;
            Total = vencimentos * Referencia;
        }
    }
}