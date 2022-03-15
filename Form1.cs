using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace panel_kontrolü_uygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
             webBrowser1.Navigate(txtAdres.Text);
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    
        {
            

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        listBox1.Items.Add(webBrowser1.Url);
        }
    }
}
