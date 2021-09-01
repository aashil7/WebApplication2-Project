using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.repository
{
    public class dataTab
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }





        public bool GetDataTable(ProjectAddEditView obj)
        {
            Connection();
            SqlCommand com = new SqlCommand("ProjectAdd_Aashil_Training ", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustomerName", obj.Project.CustomerName);
            com.Parameters.AddWithValue("@ProjectName", obj.Project.ProjectName);
            com.Parameters.AddWithValue("@ProjectId", obj.Project.ProjectId);
            com.Parameters.AddWithValue("@Start_Date", obj.Project.Start_Date);
            com.Parameters.AddWithValue("@End_Date", obj.Project.End_Date);
            com.Parameters.AddWithValue("@ProjectStatus", obj.Project.ProjectStatus);
            com.Parameters.AddWithValue("@LocationGroup", obj.Project.LocationGroup);
            com.Parameters.AddWithValue("@PayRollState", obj.Project.PayRollState);
            com.Parameters.AddWithValue("@SalesPerson", obj.Project.SalesPerson);
            com.Parameters.AddWithValue("@ProjectCategory", obj.Project.ProjectCategory);
            com.Parameters.AddWithValue("@ProjectType", obj.Project.ProjectType);
            com.Parameters.AddWithValue("@SubDomain", obj.Project.SubDomain);
            com.Parameters.AddWithValue("@TimeSheetRepresentative", obj.Project.TimeSheetRepresentative);
            com.Parameters.AddWithValue("@ClientInvoiceGroup", obj.Project.ClientInvoiceGroup);
            com.Parameters.AddWithValue("@TimeSheetType", obj.Project.TimeSheetType);
            com.Parameters.AddWithValue("@IsVMSTimeSheet", obj.Project.IsVMSTimeSheet);
            com.Parameters.AddWithValue("@PracticeType", obj.Project.PracticeType);
            com.Parameters.AddWithValue("@Recruiter", obj.Project.Recruiter);


            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }

            return false;

        }





    }
    }