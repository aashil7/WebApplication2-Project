using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Models
{
    public class View
    {

        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DbConnection"].ToString();
            con = new SqlConnection(constring);
        }

 
        public List<Project> GetView()
        {
            connection();
            List<Project> Projectlist = new List<Project>();

            SqlCommand cmd = new SqlCommand("ProjectView_Ashil_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            List<Project> Pro = new List<Project>();

         /*   con.Open();
            sd.Fill(dt);
            con.Close();*/

            foreach (DataRow dr in dt.Rows)
            {
               /* Projectlist.Add(
                    new Project*/

                Pro.Add(new Project

                    {

                        CustomerName = Convert.ToString(dr["CustomerName"]),
                        ProjectName = Convert.ToString(dr["ProjectName"]),
                        ProjectId = Convert.ToInt32(dr["ProjectId"]),
                        Start_Date = Convert.ToDateTime(dr["Start_Date"]),
                        End_Date = Convert.ToDateTime(dr["End_Date"]),
                        ProjectStatus = Convert.ToInt32(dr["ProjectStatus"]),
                        LocationGroup = Convert.ToInt32(dr["LocationGroup"]),
                        PayRollState = Convert.ToInt32(dr["PayRollState"]),
                        SalesPerson = Convert.ToInt32(dr["SalesPerson"]),
                        ProjectCategory = Convert.ToInt32(dr["ProjectCategory"]),
                        ProjectType = Convert.ToInt32(dr["ProjectType"]),
                        SubDomain = Convert.ToInt32(dr["SubDomain"]),
                        TimeSheetRepresentative = Convert.ToInt32(dr["TimeSheetRepresentative"]),
                        ClientInvoiceGroup = Convert.ToInt32(dr["ClientInvoiceGroup"]),
                        TimeSheetType = Convert.ToInt32(dr["TimeSheetType"]),
                        IsVMSTimeSheet = Convert.ToInt32(dr["IsVMSTimeSheet"]),
                        PracticeType = Convert.ToInt32(dr["PracticeType"]),
                        Recruiter = Convert.ToInt32(dr["Recruiter"]),
                    });
            }
            con.Close();
            return (Pro);
        }

    }
}