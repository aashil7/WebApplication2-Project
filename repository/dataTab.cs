using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
           

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }

            return false;

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




        [WebMethod]
        public List<Project> GetEmpData(string ProjectId)
        {
          
            string sqlconnectionstring = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            List<Project> employeelist = new List<Project>();
            using (SqlConnection con = new SqlConnection(sqlconnectionstring))
            {
                SqlCommand cmd = new SqlCommand("Aashil_Edit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter("@ProjectId", ProjectId);
                cmd.Parameters.Add(para);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
     
                {
                    Project Project = new Project();


                    Project.CustomerName = (rdr["CustumerName"].ToString());
                    Project.ProjectName = (rdr["ProjectName"].ToString());
                    Project.ProjectId = (rdr["ProjectId"].ToString());
                    Project.Start_Date = (rdr["Start_Date"].ToString());
                    Project.End_Date = (rdr["End_Date"].ToString());
                    Project.ProjectStatus = (rdr["ProjectStatus"].ToString());
                    Project.LocationGroup = (rdr["LocactionGroup"].ToString());
                    Project.PayRollState = (rdr["PayRollState"].ToString());
                    Project.SalesPerson = (rdr["SalesPerson"].ToString());
                    Project.ProjectCategory = (rdr["ProjectCategory"].ToString());
                    Project.ProjectType = (rdr["ProjectType"].ToString());
                    Project.SubDomain = (rdr["SubDomain"].ToString());
                    Project.TimeSheetRepresentative = (rdr["TimeSheetRepresentative"].ToString());
                    Project.ClientInvoiceGroup = (rdr["ClientInvoiceGroup"].ToString());
                    Project.TimeSheetType = (rdr["TimeSheetType"].ToString());
                    Project.IsVMSTimeSheet = (rdr["IsVMSTimeSheet"].ToString());
                    Project.PracticeType = (rdr["PracticeType"].ToString());
                    Project.Recruiter = (rdr["Recruiter"].ToString());

                    employeelist.Add(Project);
                }
            }

            return employeelist;
        }





        [WebMethod]
        public string Edit(int Id)
        {

            string _data = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("Aashil_ProjectEdit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProjectId", Id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                _data = JsonConvert.SerializeObject(ds.Tables[0]);
            }
            return _data;
        }


        [WebMethod]
        public bool Update(Project obj)

        {
            Connection();
            SqlCommand cmd = new SqlCommand("Aashil_Project_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerName", obj.CustomerName);
            cmd.Parameters.AddWithValue("@ProjectName", obj.ProjectName);
            cmd.Parameters.AddWithValue("@ProjectId", obj.ProjectId);
            cmd.Parameters.AddWithValue("@Start_Date", obj.Start_Date);
            cmd.Parameters.AddWithValue("@End_Date", obj.End_Date);
            cmd.Parameters.AddWithValue("@ProjectStatus", obj.ProjectStatus);
            cmd.Parameters.AddWithValue("@LocationGroup", obj.LocationGroup);
            cmd.Parameters.AddWithValue("@PayRollState", obj.PayRollState);
            cmd.Parameters.AddWithValue("@SalesPerson", obj.SalesPerson);
            cmd.Parameters.AddWithValue("@ProjectCategory", obj.ProjectCategory);
            cmd.Parameters.AddWithValue("@ProjectType", obj.ProjectType);
            cmd.Parameters.AddWithValue("@SubDomain", obj.SubDomain);
            cmd.Parameters.AddWithValue("@TimeSheetRepresentative", obj.TimeSheetRepresentative);
            cmd.Parameters.AddWithValue("@ClientInvoiceGroup", obj.ClientInvoiceGroup);
            cmd.Parameters.AddWithValue("@TimeSheetType", obj.TimeSheetType);
            cmd.Parameters.AddWithValue("@IsVMSTimeSheet", obj.IsVMSTimeSheet);
            cmd.Parameters.AddWithValue("@PracticeType", obj.PracticeType);
            cmd.Parameters.AddWithValue("@Recruiter", obj.Recruiter);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)

            {
                return true;
            }

            return false;


        }



    }
}







//List<Project> employeelist = new List<Project>();
//string CS = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
//using (SqlConnection con = new SqlConnection(CS))
//{
//    SqlCommand cmd = new SqlCommand("Aashil_ProjectRet", con);
//    cmd.CommandType = CommandType.StoredProcedure;
//    con.Open();

//    SqlDataReader rdr = cmd.ExecuteReader();

//    while (rdr.Read())