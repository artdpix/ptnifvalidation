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
            int maxNumberSize = 9;

            string filteredNumber = Regex.Match(nifNumber, @"[0-9]+").Value;

            if (filteredNumber.Length != maxNumberSize || int.Parse(filteredNumber[0].ToString()) == 0) { return false; }

            int checkSum = 0;
           
            for (int i = 0; i < maxNumberSize-1; i++)
            {
                checkSum += (int.Parse(filteredNumber[i].ToString()))*(maxNumberSize-i);
            }

            int checkDigit = 11-(checkSum % 11);
           
            if (checkDigit > 9) { checkDigit = 0; }

            return checkDigit == int.Parse(filteredNumber[maxNumberSize - 1].ToString());

        }

    }
}
