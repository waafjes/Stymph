﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolin
{
    public partial class ChooseCharacter : Form
    {
        String _Name;


        public ChooseCharacter(String Name)
        {
            InitializeComponent();
            _Name = Name;
          


        }

        private void ChooseCharacter_Load(object sender, EventArgs e)
        {
            pbRez.Visible = false;
            pbStremma.Visible = false;

        }

        private void txtChoose_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pbStremma_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRight_Click(object sender, EventArgs e)
        {   
              if(pbBle.Visible == true)
            {
                pbBle.Visible = false;
                pbRez.Visible = true;
            }
              else if (pbRez.Visible == true)
            {
                pbRez.Visible = false;
                pbStremma.Visible = true;

            }
              else if (pbStremma.Visible == true)
            {
                pbStremma.Visible = false;
                pbBle.Visible = true;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            if (pbStremma.Visible == true)
            {
                pbStremma.Visible = false;
                pbRez.Visible = true;
            }
            else if (pbRez.Visible == true) //2
            {
                pbRez.Visible = false; //2
                pbBle.Visible = true; //3
            }
            else if(pbBle.Visible == true)
            {
                pbBle.Visible = false;
                pbStremma.Visible = true;
            }

            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (pbBle.Visible == true )
            {
                Form MG = new MainGame(Name);
                MG.Show();
                this.Hide();
            }
            else if (pbStremma.Visible == true )
            {
                Form Stremma = new STRGame(Name);
                Stremma.Show();
                this.Hide();
            }
            else if (pbRez.Visible == true)
            {
                Form ROZ = new ROZGame(Name);
                ROZ.Show();
                this.Hide();
            }
        }
    }
}
