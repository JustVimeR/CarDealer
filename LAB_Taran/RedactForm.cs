using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Example;

namespace WinFormsApp_CarDealer
{
    public partial class RedactForm : Form
    {
        private readonly MainForm mainForm;

        public RedactForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedactForm redactForm = new RedactForm(mainForm);
            mainForm.dataGridView.CurrentRow.Cells[0].Value = textBoxFBrand.Text;
            mainForm.dataGridView.CurrentRow.Cells[1].Value = textBoxFModel.Text;
            mainForm.dataGridView.CurrentRow.Cells[2].Value = textBoxFCountry.Text;
            mainForm.dataGridView.CurrentRow.Cells[3].Value = textBoxFNayavnost.Text;
            mainForm.dataGridView.CurrentRow.Cells[4].Value = textBoxFMotor.Text;
            Close();

        }
    }
}
