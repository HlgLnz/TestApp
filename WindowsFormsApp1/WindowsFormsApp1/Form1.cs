using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string MESSAGEBOX_MESSAGE = "Сообщение";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) =>
            MessageBox.Show(textBox1.Text,
                MESSAGEBOX_MESSAGE,
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Закрыть приложение?",
                MESSAGEBOX_MESSAGE,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes) Application.Exit();
        }
    }
}
