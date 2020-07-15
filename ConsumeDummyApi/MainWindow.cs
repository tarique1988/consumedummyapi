using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebHelperLibrary;

namespace ConsumeDummyApi
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            WebHelper helper = new WebHelper();
            outputText.Text = await helper.GetData(urlTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
