using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TlacitkoTEST_PVA
{
    public abstract class ZakladniButton : Button
    {
        protected static int pocetKliknuti;

        protected static Action<int> ZmenPocetKliknuti;

        protected ZakladniButton()
        {
            ZmenPocetKliknuti += ZmenPocetKliknutiMetoda;
        }

        private void ZmenPocetKliknutiMetoda(int obj)
        {
            pocetKliknuti = obj;
            ReakceNaZmenuPoctu();
        }

        protected abstract void TlacitkoZakliknuto();

        protected void ReakceNaZmenuPoctu()
        {

        }
    }
}
