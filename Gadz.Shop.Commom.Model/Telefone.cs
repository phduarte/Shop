using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadz.Shop.Commom.Model {
    public struct Telefone {

        public string Ddd { get; private set; }
        public string Numero { get; private set; }
        public bool Celular { get; private set; }
        public int Digitos => Numero.Length;

        public Telefone(string numero) {

            numero = numero.Replace(" ", "").Replace("-","").Replace("(","").Replace(")","");

            Ddd = string.Empty;
            Numero = string.Empty;
            Celular = false;

            if (numero.Length >= 10) {
                Ddd = numero.Substring(0, 2);
                Numero = numero.Substring(2);
                Celular = int.Parse(Numero.Substring(0, 1)) > 6;
            }
        }

        public override string ToString() {

            var faixaB = Numero.Substring(Digitos - 4, 4);
            var faixaA = Numero.Substring(0, Digitos-4);

            return $"({Ddd}) {faixaA}-{faixaB}";
        }
    }
}
