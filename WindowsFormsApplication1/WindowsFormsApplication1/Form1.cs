using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnChangeProxy_Click(object sender, EventArgs e)
        {
            setChanges(1);
        }

        private void setChanges(int i) {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", i);
            //tbProxyAddress.Text= registry.GetValue("ProxyServer").ToString();
            registry.SetValue("ProxyServer", tbProxyAddress.Text + ":" + tbPort.Text);            
        }

        private void btnNoProxy_Click(object sender, EventArgs e)
        {
            setChanges(0);
        }
    }
}
