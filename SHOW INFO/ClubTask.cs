﻿using Project_OOP_Final.DAL;
using Project_OOP_Final.OTHERS;
using Project_OOP_Final.REMOVE;
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
    public partial class ClubTask : Form
    {

        public ClubTask()
        {
            InitializeComponent();
            loadClubTask();
        }
        #region Method
        void loadClubTask()
        {
            dtgvClubTask.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM Info_Task");
        }
        #endregion

        #region Event
        private void ClubTask_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewTask addTask = new AddNewTask();
            
            addTask.Show();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveTask removeTask = new RemoveTask();
            removeTask.Show();
            
        }
        #endregion

        private void btnRedo_Click(object sender, EventArgs e)
        {
            ReDoTask redotask = new ReDoTask();
            redotask.Show();
        }
    }
}
