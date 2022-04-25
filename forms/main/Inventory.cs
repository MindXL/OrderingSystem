using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3.forms.main
{
    public partial class Inventory : Form
    {
        private readonly Ex3DataContext db = new Ex3DataContext();
        private int n_warn = 0;

        public Inventory()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData(bool isWarn = false)
        {
            var materials = from mat in db.Material
                            join man in db.Manufacturer on mat.manId equals man.id
                            select new
                            {
                                序号 = mat.id,
                                材料 = mat.name,
                                库存数量 = mat.amount,
                                库存预警数量 = mat.warningAmount,
                                生产厂商 = man.name,
                                型号 = mat.model
                            };
            var warns = from mat in materials
                        where mat.库存数量 < mat.库存预警数量
                        select mat;

            n_warn = warns.Count();
            gvInventory.DataSource = isWarn ? warns : materials;
            lblMatNum.Text = "显示数量：" + gvInventory.RowCount.ToString();

            if (n_warn > 0)
            {
                btnWarn.Enabled = true;
                btnWarn.Text = "库存预警" + "(" + n_warn.ToString() + ")";
            }
            else
            {
                btnWarn.Enabled = false;
                btnWarn.Text = "库存预警";
            }
        }

        private void BtnShowInventory_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BtnWarn_Click(object sender, EventArgs e)
        {
            BindData(true);
        }

        private void GvInventory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    gvInventory.ClearSelection();
                    gvInventory.Rows[e.RowIndex].Selected = true;
                    gvInventory.CurrentCell = gvInventory.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cms_gvInventoryCell.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void ShowOrdersDlg()
        {
            this.Hide();
            (new Orders()).ShowDialog();
            this.Close();
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(gvInventory.SelectedRows[0].Cells[0].Value.ToString());
            ShowOrdersDlg();
        }

        private void BtnShowOrderDlg_Click(object sender, EventArgs e)
        {
            ShowOrdersDlg();
        }
    }
}