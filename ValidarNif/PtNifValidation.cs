using System.Text.RegularExpressions;

namespace ValidarNif
{
    public class PtNifValidation
    {
        /// <summary>
        /// Expects a string with a number, and checks if number is a valid PT Nif number
        /// usage PtNifValidation.Nif(nifNumber)
        /// </summary>
        /// <param name="nifNumber"></param>
        /// <returns></returns>
        public static bool Nif(string nifNumber)
        {
            int tamanhoNumero = 9; // Tamanho do número NIF

            string filteredNumber = Regex.Match(nifNumber, @"[0-9]+").Value; // extrair Número

            if (filteredNumber.Length != tamanhoNumero || int.Parse(filteredNumber[0].ToString()) == 0) { return false; } // Verificar Tamanho, e zero no inicio

            int calculoCheckSum = 0;
            // Calcular check sum
            for (int i = 0; i < tamanhoNumero - 1; i++)
            {
                calculoCheckSum += (int.Parse(filteredNumber[i].ToString()))*(tamanhoNumero - i);
            }

            int digitoVerificacao = 11-(calculoCheckSum % 11);
           
            if (digitoVerificacao > 9) { digitoVerificacao = 0; }
            // retornar validação
            return digitoVerificacao == int.Parse(filteredNumber[tamanhoNumero - 1].ToString());

        }

    }
}
