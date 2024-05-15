using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TlacitkoTEST_PVA
{
    internal class ZnicitelneTlacitko : ZakladniButton
    {
        int zivotnost;
        Random rand;
        CheckBox checkBox1;

        public ZnicitelneTlacitko(CheckBox checkBox1)
        {
            this.zivotnost = pocetKliknuti;
            this.Text = $"Počet kliknutí: {zivotnost}";
            this.checkBox1 = checkBox1;

            rand = new Random();
        }

        protected override void TlacitkoZakliknuto()
        {
            var number = rand.Next(0, 100);
            if (checkBox1.Checked)
            {
                number = 0;
            }
            if (number > 50)
            {
                this.Enabled = false;
                this.Text = "SMULA";
            } else
            {
                if (zivotnost > 0)
                {
                    zivotnost--;
                    this.Text = $"Počet kliknutí: {zivotnost}";
                } else
                {
                    this.Dispose(); 
                }
            }

            ReakceNaZmenuPoctu();
        }

        protected override void ReakceNaZmenuPoctu()
        {
            this.Text = $"Počet kliknutí: {zivotnost}";
        }
    }
}
