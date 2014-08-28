using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OneToMayRelationship_JQueryFiltered.Models;

namespace OneToMayRelationship_JQueryFiltered.DAL
{
    public class DepartmentGateway
    {
        public List<Department> GetAllDepartments()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;database=OneToMayRelationship_JQueryFiltered.Models.DepartmentEntities;Integrated Security=SSPI";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            string selectDeptQuery = "SELECT * FROM Departments";
            sqlConn.Open();
            SqlCommand sqlCommand = new SqlCommand(selectDeptQuery, sqlConn);
            SqlDataReader data = sqlCommand.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (data.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Code =  data["Code"].ToString();
                aDepartment.Name = data["Name"].ToString();
                departments.Add(aDepartment);
            }
            sqlConn.Close();
            return departments;

        }
    }
}