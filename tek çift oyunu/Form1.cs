﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tek_çift_oyunu
{
    public partial class Form1 : Form
    {
        int sayi = 0, puan = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            if (sayi % 2 != 0)
            {
                puan += 5;
            }
            else
            {
                puan -= 3;
            }
            lblPuan.Text = puan.ToString();
            btnCift.Enabled=false;
            btnTek.Enabled=false;
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, 100);
            lblSayi.Text = sayi.ToString();
            btnCift.Enabled = true;
            btnTek.Enabled = true;
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            if (sayi % 2 == 0)
            {
                puan += 5;
            }
            else
            {
                puan -= 3;
            }
            lblPuan.Text = puan.ToString();
            btnCift.Enabled = false;
            btnTek.Enabled = false;
        }
    }       
   
}
