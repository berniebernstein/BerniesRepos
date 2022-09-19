﻿using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusnissLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };
            string sql = @"insert into dbo.Employee (EmployeeId,FirstName,LastName,EmailAddress)
                                values (@EmployeeId,@FirstName,@LastName,@EmailAddress);";
            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress FROM dbo.Employee;";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
