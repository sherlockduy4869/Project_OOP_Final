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

namespace Project_OOP_Final.OTHERS
{
    public partial class ReDoTask : Form
    {
        public ReDoTask()
        {
            InitializeComponent();
            loadTaskId();
        }
        void loadTaskId()
        {
            List<string> list = MemberDAL.Instance.getTaskId();
            cbTaskId.DataSource = list;
        }
        private void btnRedo_Click(object sender, EventArgs e)
        {
            string taskId = cbTaskId.Text;
            string note = txbNote.Text;

            try
            {
                int i = LeaderDAL.Instance.redoTask(taskId, note);

                if (i != 0)
                {
                    txbNote.Text = string.Empty;
                    MessageBox.Show("Done");
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

        private void ReDoTask_Load(object sender, EventArgs e)
        {

        }
    }
}
