﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Dönem_Projesi
{
    public partial class CustomerPanel : Form
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }

        private void CustomerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowManager.CloseForm(this);
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
