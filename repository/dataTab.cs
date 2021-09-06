using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
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
            //com.Parameters.AddWithValue("@ID", obj.ID);

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



        //[WebMethod]
        //public string GetEmpData()
        //{

        //    con.Open();
        //    string _data = "";
        //    SqlCommand cmd = new SqlCommand("Aashil_ProjectRet", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    con.Close();
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        _data = JsonConvert.SerializeObject(ds.Tables[0]);
        //    }
        //    return _data;
        //}




        //[WebMethod]
        //public string Edit(int Id)
        //{

        //    string _data = "";
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Aashil_ProjectEdit", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@ProjectId", Id);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    con.Close();
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        _data = JsonConvert.SerializeObject(ds.Tables[0]);
        //    }
        //    return _data;
        //}


        //[WebMethod]
        //public bool Update(Project obj)

        //{

        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("Aashil_Project_Update", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@CustomerName", obj.CustomerName);
        //    cmd.Parameters.AddWithValue("@ProjectName", obj.ProjectName);
        //    cmd.Parameters.AddWithValue("@ProjectId", obj.ProjectId);
        //    cmd.Parameters.AddWithValue("@Start_Date", obj.Start_Date);
        //    cmd.Parameters.AddWithValue("@End_Date", obj.End_Date);
        //    cmd.Parameters.AddWithValue("@ProjectStatus", obj.ProjectStatus);
        //    cmd.Parameters.AddWithValue("@LocationGroup", obj.LocationGroup);
        //    cmd.Parameters.AddWithValue("@PayRollState", obj.PayRollState);
        //    cmd.Parameters.AddWithValue("@SalesPerson", obj.SalesPerson);
        //    cmd.Parameters.AddWithValue("@ProjectCategory", obj.ProjectCategory);
        //    cmd.Parameters.AddWithValue("@ProjectType", obj.ProjectType);
        //    cmd.Parameters.AddWithValue("@SubDomain", obj.SubDomain);
        //    cmd.Parameters.AddWithValue("@TimeSheetRepresentative", obj.TimeSheetRepresentative);
        //    cmd.Parameters.AddWithValue("@ClientInvoiceGroup", obj.ClientInvoiceGroup);
        //    cmd.Parameters.AddWithValue("@TimeSheetType", obj.TimeSheetType);
        //    cmd.Parameters.AddWithValue("@IsVMSTimeSheet", obj.IsVMSTimeSheet);
        //    cmd.Parameters.AddWithValue("@PracticeType", obj.PracticeType);
        //    cmd.Parameters.AddWithValue("@Recruiter", obj.Recruiter);

        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    {
        //        return true;
        //    }


          

        //}
               


  