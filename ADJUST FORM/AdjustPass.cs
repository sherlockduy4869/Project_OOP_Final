﻿using Project_OOP_Final.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OOP_Final
{
    
    public partial class AdjustPass : Form
    {
        private string passNow;
        public AdjustPass()
        {
            InitializeComponent();
        }
        #region Method
        public void getPassNow(string pass)
        {
            passNow = pass;
        }
        string encodingPass(string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        #endregion
        #region Event
        private void AdjustPass_Load(object sender, EventArgs e)
        {

        } 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txbUserName_Click(object sender, EventArgs e)
        {
            txbUserName.Clear();
        }

        private void txbCurrentPass_Click(object sender, EventArgs e)
        {
            txbCurrentPass.Clear();
        }

        private void txbNewPass_Click(object sender, EventArgs e)
        {
            txbNewPass.Clear();
        }

        private void txbReEnterPass_Click(object sender, EventArgs e)
        {
            txbReEnterPass.Clear();
        }
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string currentPass = encodingPass(txbCurrentPass.Text);
            string newPass = encodingPass(txbNewPass.Text);
            string reNewPass = encodingPass(txbReEnterPass.Text);
            string pass = passNow;
            try
            {
                if(userName == String.Empty || txbNewPass.Text == String.Empty)
                {
                    MessageBox.Show("Please fully enter your information");
                }
                else
                {
                    if (currentPass == pass)
                    {
                        if (newPass == reNewPass)
                        {
                            int i = AdjustDAL.Instance.adjustPass(userName, newPass);

                            if (i != 0)
                            {
                                txbCurrentPass.Text = string.Empty;
                                txbNewPass.Text = string.Empty;
                                txbReEnterPass.Text = string.Empty;

                                MessageBox.Show("Adjusted Pass");

                            }
                            else
                            {
                                MessageBox.Show("Failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please re enter new password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please re enter current password");
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR 404");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbUserName.Clear();
            txbCurrentPass.Clear();
            txbNewPass.Clear();
            txbReEnterPass.Clear();
        }
        #endregion

    }
}
