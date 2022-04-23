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
    public partial class SelectMaterial : Form
    {
        private static SelectMaterial dlg = null;

        private IQueryable<Manufacturer> manufacturers = null;
        private IQueryable<Material> materials = null;

        public SelectMaterial()
        {
            InitializeComponent();
            dlg = this;

            Ex3DataContext db = new Ex3DataContext();

            manufacturers = from man in db.Manufacturer
                            select man;
            materials = from mat in db.Material
                        select mat;
            cbxManufacturer.DataSource = from man in manufacturers
                                         select man.name;
        }

        public static void ShowUnique()
        {
            if (dlg == null)
            {
                dlg = new SelectMaterial();
                dlg.Show();
            }
            dlg.Focus();
        }

        private void SelectMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            dlg = null;
        }

        private void cbxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxModel.DataSource = from mat in materials
                                  where mat.manId == cbxManufacturer.SelectedIndex + 1
                                  select mat.model;
        }
    }
}