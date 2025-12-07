using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_12
{
    public partial class FServ : Form
    {
        public FServ()
        {
            InitializeComponent();
            FservTB.Text = Form1.GlStringParameter; // Якщо фільтр уже був, то відразу записуємо його у вікно введення
        }

        private void FservBOk_Click(object sender, EventArgs e)
        {
            Form1.GlStringParameter = FservTB.Text; // Записати введений критерій у основну форму
            Close();
        }
    }
}
