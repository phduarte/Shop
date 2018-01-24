using System;

namespace Gadz.Shop.Commom.Utils {
    public class Funcoes {

        /**
         * <summary>
         * Retorna o número de caracteres especificado do final de uma sequência de caracteres de texto.
         * </summary>
         * <param name="text">É a sequência de caracteres de texto que comtém os caracteres que se deseja extrair.</param>
         * <param name="len">Especifica o número de caracteres que se deseja extrair, 1 quando não especificado.</param>
         */
        public static string Rigth(string text, int len = 1) {

            string _r;
            int _i = text.Length - len;

            try {
                _r = text.Substring(_i, len);
            }
            catch {
                _r = text;
            }

            return _r;
        }

        /**
         * <summary>
         * Retorna o número especificado de caracteres do início de uma sequência de caracteres de texto.
         * </summary>
         * <param name="text">É a sequência de caracteres de texto que comtém os caracteres que se deseja extrair.</param>
         * <param name="len">Especifica quantos caracteres à ESQUEDA deve extrair; retorna 1 quando não especificado.</param>
         */
        public static string Left(string text, int len = 1) {

            string _r;
            int _i = 0;

            try {
                _r = text.Substring(_i, len);
            }
            catch {
                _r = text;
            }

            return _r;
        }

        //<summary>
        //Retira todos os caracteres de valor monetário, hífen e subscrito
        //</summary>
        public static string RemoveMask(string text) {

            text = text.Replace(".","");
            text = text.Replace("-", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace("_", "");
            text = text.Replace(" ", "");
            text = text.Replace("R$", "");

            if (text.Length == 1 && text.Equals(",")) {
                text = "0";
            }

            return text;
        }

        public static string Valor(string value) {

            Single _value = 0F;

            if (value != "")
                _value = Convert.ToSingle(value.Replace("R$ ", ""));

            return String.Format("{0:C}", _value);
        }

        /// <summary>
        /// Realiza a validação do CNPJ - Thanks Marcoratti fonte: http://www.macoratti.net/11/09/c_val1.htm
        /// </summary>
        public static bool ValidaCNPJ(string cnpj) {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// Realiza a validação do CPF - Thanks Marcoratti fonte: http://www.macoratti.net/11/09/c_val1.htm
        /// </summary>
        public static bool ValidaCPF(string cpf) {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// Realiza a validação do número PIS - Thanks Marcoratti fonte: http://www.macoratti.net/11/09/c_val1.htm
        /// </summary>
        public static bool ValidaPis(string pis) {
            int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            if (pis.Trim().Length != 11)
                return false;
            pis = pis.Trim();
            pis = pis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(pis[i].ToString()) * multiplicador[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            return pis.EndsWith(resto.ToString());
        }
    }
}