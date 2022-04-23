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

namespace Ex3.forms.main
{
    public partial class Orders : Form
    {
        private readonly Ex3DataContext db = new Ex3DataContext();

        private enum OrderState
        { NULL = -1, Unaurhorized = 0, Unfinished, Finished };

        public Orders()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData(OrderState state = OrderState.NULL)
        {
            var orders =
                state == OrderState.NULL ?
                from o in db.Order
                select o
                :
                from o in db.Order
                where state.Equals(o.state)
                select o;

            gvOrder.DataSource = orders;
            lblOrdNum.Text = "显示数量：" + orders.Count().ToString();
        }

        private void btnShowAllOrder_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnShowUnauthorized_Click(object sender, EventArgs e)
        {
            BindData(OrderState.Unaurhorized);
        }

        private void btnShowUnfinished_Click(object sender, EventArgs e)
        {
            BindData(OrderState.Unfinished);
        }

        private void btnShowFinished_Click(object sender, EventArgs e)
        {
            BindData(OrderState.Finished);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder.ShowUnique();
        }
    }
}