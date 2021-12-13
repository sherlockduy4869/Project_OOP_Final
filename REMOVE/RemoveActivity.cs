﻿using Project_OOP_Final.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_Final
{
    public partial class RemoveActivity : Form
    {
        public RemoveActivity()
        {
            InitializeComponent();
        }

        #region Event
        private void RemoveActivity_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            try
            {

                int i = ActivityDAL.Instance.remove(id);

                if (i != 0)
                {
                    txbID.Text = String.Empty;
                    MessageBox.Show("Removed");
                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        #endregion
    }
}
