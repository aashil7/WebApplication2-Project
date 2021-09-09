using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.repository
{
    public class common
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }

        public List<AppRefData> GetAppRefData(int parentId)
        {
            List<AppRefData> appRefDataList = new List<AppRefData>();
            Connection();
            SqlCommand cmd = new SqlCommand("GetAppRefData_Training_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@parentId", SqlDbType.Int);
            cmd.Parameters["@parentId"].Value = parentId;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new AppRefData { KeyId = Convert.ToInt32(reader["KeyId"]), KeyName = Convert.ToString(reader["KeyName"]) }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Projlist> GetRecrut()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_ActualRecrut_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["Full_Name"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Projlist> GetDomain()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_SubDomain_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["KeyId"]), Name = reader["KeyName"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Projlist> GetLocation()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_LocationGroup_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["LOCATION_ID"]), Name = reader["LOCATION_NAME"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }


        public List<Projlist> GetTimeSheetRep()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_TimeSheetRep_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["TimeSheetRepresentative"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<Projlist> GetSalePerson()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_SalesPerson_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["SalesPerson"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }

        public List<Projlist> GetPayRoll()
        {
            List<Projlist> appRefDataList = new List<Projlist>();
            Connection();
            SqlCommand cmd = new SqlCommand("Get_PayRollState_Ashil", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                appRefDataList.Add(
                    new Projlist { Id = Convert.ToInt32(reader["State_Id"]), Name = reader["Payroll_State"].ToString() }
                    );
            }

            reader.Close();
            con.Close();

            return appRefDataList;
        }




        public List<Project> GetProjectsList()
        {
            DataSet ds = new DataSet();
            List<Project> SelectListNew = new List<Project>();
            Connection();
            SqlCommand cmd = new SqlCommand("ProjectList_Aashil", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(ds);
            }
            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Project obj = new Project();
                    obj.CustomerName = Convert.ToString(ds.Tables[0].Rows[i]["CustumerName"]);
                    obj.ProjectName = Convert.ToString(ds.Tables[0].Rows[i]["ProjectName"]);
                    obj.ProjectId = Convert.ToString(ds.Tables[0].Rows[i]["ProjectId"]);
                    obj.Start_Date = Convert.ToString(ds.Tables[0].Rows[i]["Start_Date"]);
                    obj.End_Date = Convert.ToString(ds.Tables[0].Rows[i]["End_Date"]);
                    obj.ProjectStatus = Convert.ToString(ds.Tables[0].Rows[i]["ProjectStatus"]);
                    obj.LocationGroup = Convert.ToString(ds.Tables[0].Rows[i]["LocationGroup"]);
                    obj.PayRollState = Convert.ToString(ds.Tables[0].Rows[i]["PayRollState"]);
                    obj.SalesPerson = Convert.ToString(ds.Tables[0].Rows[i]["SalesPerson"]);
                    obj.ProjectCategory = Convert.ToString(ds.Tables[0].Rows[i]["ProjectCategory"]);
                    obj.ProjectType = Convert.ToString(ds.Tables[0].Rows[i]["ProjectType"]);
                    obj.SubDomain = Convert.ToString(ds.Tables[0].Rows[i]["SubDomain"]);
                    obj.TimeSheetRepresentative = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetRepresentative"]);
                    obj.ClientInvoiceGroup = Convert.ToString(ds.Tables[0].Rows[i]["ClientInvoieGroup"]);
                    obj.TimeSheetType = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetType"]);
                    obj.IsVMSTimeSheet = Convert.ToString(ds.Tables[0].Rows[i]["IsVMSTimeSheet"]);
                    obj.PracticeType = Convert.ToString(ds.Tables[0].Rows[i]["PracticeType"]);
                    obj.Recruiter = Convert.ToString(ds.Tables[0].Rows[i]["Recruiter"]);
                    SelectListNew.Add(obj);
                }
            }
     
            return SelectListNew;
        }






        //public bool GetManageSearch(Project obj)
        //{
        //    Connection();
        //    SqlCommand cmd = new SqlCommand("ManageProject_Aashil", con);
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

        //    con.Open();
        //    int i = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (i >= 1)

        //    {
        //        return true;
        //    }

        //    return false;
        //}






    }
}