using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstTukling_C
{
    internal class ChangeLetters
    {
        public void ChangeLetter()
        {
            string orginalText = "Terje";
            string endretTekst = orginalText
                .Replace('e', 'a');
            Console.WriteLine(endretTekst);
        }
    }
}
