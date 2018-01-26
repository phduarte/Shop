using Gadz.Shop.Commom.Model;
using System.Text.RegularExpressions;

namespace Gadz.Shop.Delivery.DomainModel.Enderecos {

    internal class Endereco : Entity, IEndereco {

        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Cep { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public float Distancia { get; set; }

        public Endereco(string endereco) {

            Regex cep = new Regex(@"(\d{5}\-\d{3})");

            var resultado = cep.Matches(endereco);
            if(resultado.Count > 0) {
                Cep = resultado[0].Value.Replace("-",string.Empty);
            }

            Regex rua = new Regex(@"^Rua\s.*?,");

            resultado = rua.Matches(endereco);

            if(resultado.Count > 0) {
                Logradouro = resultado[0].Value.Replace(",", string.Empty);
            }
        }
    }
}
