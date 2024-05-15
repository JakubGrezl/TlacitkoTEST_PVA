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

        protected static Action ZmenPocetKliknuti;

        protected ZakladniButton()
        {
            ZmenPocetKliknuti += ReakceNaZmenuPoctu;
            this.AutoSize = true;
        }


        protected abstract void TlacitkoZakliknuto();

        protected virtual void ReakceNaZmenuPoctu()
        {
        } 


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            pocetKliknuti++;
            ZmenPocetKliknuti.Invoke();
            TlacitkoZakliknuto();
        }
    }
}
