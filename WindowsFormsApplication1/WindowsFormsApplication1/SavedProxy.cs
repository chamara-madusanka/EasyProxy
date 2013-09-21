using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SavedProxy : Form
    {
        private Form1 form1;

        public SavedProxy()
        {
            InitializeComponent();
        }

        public SavedProxy(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1.Visible = true;
        }

        private void btnLoadProxy_Click(object sender, EventArgs e)
        {
            form1.textProxyAddress.Text = "192.248.16.90";
            form1.textPort.Text = "3128";

            form1.Visible = true;
            this.Visible = false;

        }

        
    }
}
