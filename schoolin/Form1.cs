﻿using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 begin = new Form1();
            string subPath = "C:\\Stymph";
            bool exists = Directory.Exists(subPath);

            if (!exists)
            {
                Directory.CreateDirectory(subPath);
            }


            try
            {
                string contents = File.ReadAllText("C:\\Stymph\\Stymphian.stymp");
               
               
                if (contents.Contains("Ble"))
                {
                   
                    Form MG = new MainGame(Name);
                    MG.Show(this);

                }

                if (contents.Contains("Stremma"))
                {
                    begin.Hide(); 
                    Form Stremma = new STRGame(Name);
                    Stremma.Show(this);

                }

                if (contents.Contains("Roz"))
                {
                    
                    begin.Hide();
                    Form ROZ = new ROZGame(Name);     
                    ROZ.Show(this);

                }
            }
            catch
            {
              
            }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String Name;
            Name = txtName.Text;
            if (txtName.Text == "")
            {
                MessageBox.Show("fill in your name bro.");
            }
            else
            {
               
                // Create a new instance of the Form2 class, ik geef hier ook de variable naam mee zodat ik die kan gebruiken in het volgende form
                Form CC = new ChooseCharacter(Name);
                this.Hide();
                CC.Show(this);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
