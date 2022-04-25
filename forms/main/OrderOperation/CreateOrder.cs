using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ex3.lib;

namespace Ex3.forms.main.OrderOperation
{
    public partial class CreateOrder : Form
    {
        private static CreateOrder dlg = null;

        private static List<UnfinishedRecord> records = null;
        private static DataTable dt = null;

        private CreateOrder()
        {
            InitializeComponent();
            dlg = this;

            records = new List<UnfinishedRecord>();
            dt = new DataTable();
            dt.Columns.Add("材料");
            dt.Columns.Add("数量");
            dt.Columns.Add("型号");
            dt.Columns.Add("生产厂商");
            dt.Columns.Add("供货商");

            BindData();
        }

        public static void ShowUnique()
        {
            if (dlg == null)
            {
                dlg = new CreateOrder();
                dlg.ShowDialog();
            }
        }

        private void CreateOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            dlg = null;
            records = null;
            dt = null;
        }

        private void BindData()
        {
            gvMaterials.DataSource = dt;
        }

        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
            SelectMaterial.ShowUnique();

            BindData();
        }

        public static void AddRecord(int matId, string matName, int matAmount, string matModel, string manName, int supId, string supName)
        {
            UnfinishedRecord record = new UnfinishedRecord
            {
                matId = matId,
                supId = supId,
                amount = 0,
                expectAmount = matAmount
            };
            records.Add(record);
            dt.Rows.Add(matName, matAmount, matModel, manName, supName);
        }

        private static string HashOrderId()
        {
            return DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
        }

        private static bool ValidatePrice(string s)
        {
            try
            {
                double num = double.Parse(s);
                if (num < 0)
                {
                    MessageBox.Show("价格必须大于等于0");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("价格必须是有效的数");
                return false;
            }
            return true;
        }

        private void TxtTotalPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtTotalPrice.Text.Length > 0)
                ValidatePrice(txtTotalPrice.Text);
        }

        private void TxtFinalPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtFinalPrice.Text.Length > 0)
                ValidatePrice(txtFinalPrice.Text);
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text.Length == 0)
            {
                MessageBox.Show("请填写总金额");
                return;
            }
            if (txtFinalPrice.Text.Length == 0)
            {
                MessageBox.Show("请填写成交价");
                return;
            }
            if (!ValidatePrice(txtTotalPrice.Text) || !ValidatePrice(txtFinalPrice.Text))
                return;
            if (records.Count == 0)
            {
                MessageBox.Show("订单中无记录，无法创建订单。");
                return;
            }

            string orderId = HashOrderId();
            foreach (UnfinishedRecord record in records)
            {
                record.orderId = orderId;
            }

            Order order = new Order
            {
                id = orderId,
                state = (byte)OrderState.Unaurhorized,
                description = txtDescription.Text,
                principalId = Globals.character.id,
                totalPrice = decimal.Parse(txtTotalPrice.Text),
                finalPrice = decimal.Parse(txtFinalPrice.Text),
                genDate = DateTime.Now
            };

            Ex3DataContext db = new Ex3DataContext();
            db.Order.InsertOnSubmit(order);
            db.UnfinishedRecord.InsertAllOnSubmit(records);
            db.SubmitChanges();

            MessageBox.Show("订单生成完毕，订单号为：" + orderId);
            this.Close();
        }
    }
}