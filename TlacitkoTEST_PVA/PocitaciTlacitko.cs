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

        public PocitaciTlacitko()
        {
            this.Text = $"Počet kliknutí: {lokalniPocetKliknuti} / {pocetKliknuti}";
            ZmenPocetKliknuti += HelpMetoda;
        }

        protected override void TlacitkoZakliknuto()
        {
            lokalniPocetKliknuti++;
        }

        public void HelpMetoda(int obj)
        {
            obj = pocetKliknuti + 1;
            this.Text = $"Počet kliknutí: {lokalniPocetKliknuti} / {pocetKliknuti}";
        }
    }
}
