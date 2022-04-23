using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.forms.main.OrderOperation
{
    public partial class CreateOrder : Form
    {
        private static CreateOrder dlg = null;

        private CreateOrder()
        {
            InitializeComponent();
            dlg = this;
        }

        public static void ShowUnique()
        {
            if (dlg == null)
            {
                dlg = new CreateOrder();
                dlg.Show();
            }
            dlg.Focus();
        }

        private void CreateOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            dlg = null;
        }

        private string GenOrderId()
        {
            return DateTime.Now.ToString();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            SelectMaterial.ShowUnique();
        }
    }
}