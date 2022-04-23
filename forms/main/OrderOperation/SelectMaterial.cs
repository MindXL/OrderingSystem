using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace Ex3.forms.main.OrderOperation
{
    public partial class SelectMaterial : Form
    {
        private static SelectMaterial dlg = null;
        private readonly IQueryable<Manufacturer> manufacturers = null;
        private readonly IQueryable<Material> materials = null;
        private readonly IQueryable<Supplier> suppliers = null;
        private readonly IQueryable<ManSupCoop> manSupCoops = null;

        private int[] MatIds = null;
        private int[] SupIds = null;

        public SelectMaterial()
        {
            InitializeComponent();
            dlg = this;

            Ex3DataContext db = new Ex3DataContext();
            manufacturers = from man in db.Manufacturer
                            select man;
            materials = from mat in db.Material
                        select mat;
            suppliers = from sup in db.Supplier
                        select sup;
            manSupCoops = from coop in db.ManSupCoop
                          select coop;
        }

        private void SelectMaterial_Load(object sender, EventArgs e)
        {
            cbxManName.DataSource = from man in manufacturers
                                    select man.name;
        }

        public static void ShowUnique()
        {
            if (dlg == null)
            {
                dlg = new SelectMaterial();
                dlg.ShowDialog();
            }
        }

        private void SelectMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            dlg = null;
        }

        private void cbxManName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int manId = cbxManName.SelectedIndex + 1;
            var mats = from mat in materials
                       where mat.manId == manId
                       select new
                       {
                           mat.id,
                           mat.model,
                           mat.name,
                       };

            MatIds = mats.Select(mat => mat.id).ToArray();
            cbxMatModel.DataSource = mats.Select((mat) => mat.model);
            cbxMatName.DataSource = mats.Select((mat) => mat.name);

            var sups = from sup in suppliers
                       where
                       (from coop in manSupCoops
                        where coop.manId == manId
                        select coop.supId
                       ).Contains(sup.id)
                       select new
                       {
                           sup.id,
                           sup.name
                       };
            SupIds = sups.Select((sup) => sup.id).ToArray();
            cbxSupName.DataSource = sups.Select((sup) => sup.name);
        }

        private void cbxMatModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxMatName.SelectedIndex = cbxMatModel.SelectedIndex;
        }

        private void cbxMatName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxMatModel.SelectedIndex = cbxMatName.SelectedIndex;
        }

        private void txtMatAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtMatAmount.Text.Length > 0)
            {
                try
                {
                    int num = int.Parse(txtMatAmount.Text);
                    if (num <= 0)
                        MessageBox.Show("数量必须大于0");
                }
                catch
                {
                    MessageBox.Show("数量必须是整数");
                }
            }
        }

        private void cbxSupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var principal = (from sup in suppliers
                             where
                             (from coop in manSupCoops
                              where coop.manId == cbxManName.SelectedIndex + 1
                              select coop.supId
                             ).Contains(sup.id) && sup.name == cbxSupName.Text
                             select new
                             {
                                 sup.principalName,
                                 sup.principalPhone,
                                 sup.principalEmail
                             }).First();
            txtSupPriName.Text = principal.principalName;
            txtSupPriPhone.Text = principal.principalPhone;
            txtSupPriEmail.Text = principal.principalEmail;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateOrder.AddRecord(
                    MatIds[cbxManName.SelectedIndex],
                    cbxMatName.Text,
                    int.Parse(txtMatAmount.Text),
                    cbxMatModel.Text,
                    cbxManName.SelectedIndex + 1,
                    cbxManName.Text,
                    SupIds[cbxSupName.SelectedIndex],
                    cbxSupName.Text
                );
            MessageBox.Show("添加成功！");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}