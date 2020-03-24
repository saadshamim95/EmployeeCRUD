﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Employee
    {
        private int empId;
        private string email;
        private string password;
        private string mobile;
        private string address;

        public int EmpID
        {
            get
            {
                return this.empId;
            }
            set 
            {
                this.empId = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
    }
}