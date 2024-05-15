﻿using System;
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

        public ZnicitelneTlacitko()
        {
            this.zivotnost = pocetKliknuti;
            this.Text = $"Počet kliknutí: {zivotnost}";

            rand = new Random();
        }

        protected override void TlacitkoZakliknuto()
        {
            var number = rand.Next(0, 100);
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
