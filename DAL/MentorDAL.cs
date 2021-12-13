﻿using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    public class MentorDAL : PersonDAL
    {
        private static MentorDAL instance;
        public static MentorDAL Instance
        {
            get { if (instance == null) instance = new MentorDAL(); return instance; }
            private set { instance = value; }
        }
        private MentorDAL() { }
        public Mentor GetInfoById(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Info_Mentor Where Id = '" + id + "'");
            foreach (DataRow row in data.Rows)
            {
                return new Mentor(row);
            }
            return null;
        }
        public int addNew(string id, string name, string clas, string phone)
        {
            string sql = "Insert into Info_Mentor(Id,Name,Class,Phone) VALUES('" + id + "','" + name + "','" + clas + "','" + phone + "')";

            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
        public int remove(string id, string role)
        {
            string sql = "DELETE FROM Info_Mentor WHERE Id='" + id + "' and role='" + role + "'";
            int i = DataProvider.Instance.ExecuteNonQuery(sql);
            return i;
        }
    }
}
