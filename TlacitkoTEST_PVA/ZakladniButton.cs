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
            
            this.AutoSize = true;
        }

        protected void ZmenPocetKliknutiMetoda(int obj)
        {
            pocetKliknuti = obj;
            ReakceNaZmenuPoctu();
        }

        protected abstract void TlacitkoZakliknuto();

        protected void ReakceNaZmenuPoctu()
        {
        } 

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            ZmenPocetKliknuti.Invoke(++pocetKliknuti);
            TlacitkoZakliknuto();
        }
    }
}
