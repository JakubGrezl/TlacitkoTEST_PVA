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
        }

        protected override void TlacitkoZakliknuto()
        {
            lokalniPocetKliknuti++;
            ReakceNaZmenuPoctu();
        }

        protected override void ReakceNaZmenuPoctu()
        {
            this.Text = $"Počet kliknutí: {lokalniPocetKliknuti} / {pocetKliknuti}";
        }
    }
}
