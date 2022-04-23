﻿using System;
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

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            SelectMaterial.ShowUnique();

            BindData();
        }

        public static void AddRecord(int matId, string matName, int matAmount, string matModel, int manId, string manName, int supId, string supName)
        {
            UnfinishedRecord record = new UnfinishedRecord();
            record.matId = matId;
            record.supId = supId;
            record.amount = 0;
            record.expectAmount = matAmount;
            records.Add(record);
            dt.Rows.Add(matName, matAmount, matModel, manName, supName);
        }

        private static string HashOrderId()
        {
            return DateTime.Now.ToString();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text.Length > 0)
                ValidatePrice(txtTotalPrice.Text);
        }

        private void txtFinalPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtFinalPrice.Text.Length > 0)
                ValidatePrice(txtFinalPrice.Text);
        }

        private static void ValidatePrice(string s)
        {
            try
            {
                double num = double.Parse(s);
                if (num < 0)
                    MessageBox.Show("价格必须大于等于0");
            }
            catch
            {
                MessageBox.Show("价格必须是有效的数");
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string orderId = HashOrderId();
            foreach (UnfinishedRecord record in records)
            {
                record.orderId = orderId;
            }

            Order order = new Order();
            order.state = (byte)OrderState.Unaurhorized;
            order.description = txtDescription.Text;
            order.principalId = Globals.character.id;
            order.totalPrice = int.Parse(txtTotalPrice.Text);
            order.finalPrice = int.Parse(txtFinalPrice.Text);
            order.genDate = DateTime.Now;

            Ex3DataContext db = new Ex3DataContext();
            db.Order.InsertOnSubmit(order);
            db.UnfinishedRecord.InsertAllOnSubmit(records);
            db.SubmitChanges();

            MessageBox.Show("订单生成完毕，订单号为：" + orderId);
            this.Close();
        }
    }
}