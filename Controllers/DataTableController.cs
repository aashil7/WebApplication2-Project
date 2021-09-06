using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Services;
using WebApplication2.Models;
using WebApplication2.repository;

namespace WebApplication2.Controllers
{
    public class DataTableController : Controller

    {
        private SqlConnection con;

        // GET: DataTable
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DataTab()
        {
            return View();
        }


       

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }





        public bool GetDataTable(Project obj)
        {
            Connection();
            SqlCommand com = new SqlCommand("Project_Ashil_Training", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CustomerName", obj.CustomerName);
            com.Parameters.AddWithValue("@ProjectName", obj.ProjectName);
            com.Parameters.AddWithValue("@ProjectId", obj.ProjectId);
            com.Parameters.AddWithValue("@Start_Date", obj.Start_Date);
            com.Parameters.AddWithValue("@End_Date", obj.End_Date);
            com.Parameters.AddWithValue("@ProjectStatus", obj.ProjectStatus);
            com.Parameters.AddWithValue("@LocationGroup", obj.LocationGroup);
            com.Parameters.AddWithValue("@PayRollState", obj.PayRollState);
            com.Parameters.AddWithValue("@SalesPerson", obj.SalesPerson);
            com.Parameters.AddWithValue("@ProjectCategory", obj.ProjectCategory);
            com.Parameters.AddWithValue("@ProjectType", obj.ProjectType);
            com.Parameters.AddWithValue("@SubDomain", obj.SubDomain);
            com.Parameters.AddWithValue("@TimeSheetRepresentative", obj.TimeSheetRepresentative);
            com.Parameters.AddWithValue("@ClientInvoiceGroup", obj.ClientInvoiceGroup);
            com.Parameters.AddWithValue("@TimeSheetType", obj.TimeSheetType);
            com.Parameters.AddWithValue("@IsVMSTimeSheet", obj.IsVMSTimeSheet);
            com.Parameters.AddWithValue("@PracticeType", obj.PracticeType);
            com.Parameters.AddWithValue("@Recruiter", obj.Recruiter);


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