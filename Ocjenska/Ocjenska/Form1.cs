using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Ocjenska
{
    public partial class Form1 : Form
    {
        List<Lista> list = new List<Lista>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                Lista lista = new Lista(txtModel.Text,
                    Convert.ToInt16(txtGodina.Text),
                    Convert.ToInt16(txtBrojKotača.Text));

                txtBrojKotača.Clear();
                txtGodina.Clear();
                txtModel.Clear();

                DialogResult upit = MessageBox.Show("Želite li unjeti još podataka?", "Upit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        {
                            list.Add(lista);
                            break;
                        }

                    case DialogResult.No:
                        {
                            txtBrojKotača.Enabled = false;
                            txtGodina.Enabled = false;
                            txtModel.Enabled = false;
                            break;
                        }
                }
            }

            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogrešan unos!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
