using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TlacitkoTEST_PVA
{
    public class PocitaciTlacitko : ZakladniButton
    {
        int lokalniPocetKliknuti;

        protected override void TlacitkoZakliknuto()
        {
            lokalniPocetKliknuti++;
            pocetKliknuti++;

            this.Text = $"Počet kliknutí: {lokalniPocetKliknuti} / {pocetKliknuti}";
        }
    }
}
