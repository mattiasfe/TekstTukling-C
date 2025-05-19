using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekstTukling_C
{
    internal class Class1
    {
        public void StartTekstTukling()
        {
            string originalText = "Terje";
            string flipped = new string(originalText.Reverse().ToArray());
            Console.WriteLine(flipped);
        }
    }

}
