using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ex3.forms.main.OrderOperation;
using Ex3.lib;

namespace Ex3.forms.main
{
    public partial class Orders : Form
    {
        private readonly Ex3DataContext db = new Ex3DataContext();

        public Orders()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData(OrderState state = OrderState.NULL)
        {
            var orders = from o in db.Order
                         join u in db.User on o.principalId equals u.id
                         where (state == OrderState.NULL || state.Equals(o.state))
                         select new
                         {
                             订单号 = o.id,
                             状态 = Utils.TranslateOrderState(int.Parse(o.state.ToString())),
                             描述 = o.description,
                             负责人 = u.name,
                             总价格 = o.totalPrice,
                             成交价 = o.finalPrice,
                             订单创建日期 = o.genDate.ToString(),
                             订单批准日期 = o.approveDate == null ? "" : o.approveDate.ToString(),
                             订单完成日期 = o.finishDate == null ? "" : o.finishDate.ToString()
                         };

            gvOrder.DataSource = orders;
            lblOrdNum.Text = "显示数量：" + orders.Count().ToString();
        }

        private void BtnShowAllOrder_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BtnShowUnauthorized_Click(object sender, EventArgs e)
        {
            BindData(OrderState.Unaurhorized);
        }

        private void BtnShowUnfinished_Click(object sender, EventArgs e)
        {
            BindData(OrderState.Unfinished);
        }

        private void BtnShowFinished_Click(object sender, EventArgs e)
        {
            BindData(OrderState.Finished);
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder.ShowUnique();
        }

        private void BtnShowInventoryDlg_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Inventory()).ShowDialog();
            this.Close();
        }
    }
}