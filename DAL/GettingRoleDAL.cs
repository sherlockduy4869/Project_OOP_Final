﻿using Project_OOP_Final.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DAL
{
    class GettingRoleDAL
    {
        public static PersonDAL getRoleForRemoving(string role)
        {
            if(role == "Member")
            {
                return new MemberDAL();
            }
            else if (role == "Leader")
            {
                return new LeaderDAL();
            }
            else 
            
                return new MentorDAL();   
        }
        public static PersonDAL getRoleForAdding(string role)
        {
            if (role == "Member")
            {
                return new MemberDAL();
            }
            else if (role == "Leader")
            {
                return new LeaderDAL();
            }
            else

                return new MentorDAL();
        }
    }
}
