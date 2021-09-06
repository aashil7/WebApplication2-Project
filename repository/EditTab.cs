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
    public class EditTab
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }



        //[HttpPost]
        //public ActionResult GetEditTable(int ID)
        //{
            
            
        //        EditTab editab = new EditTab();
        //        Connection();
        //        SqlCommand cmd = new SqlCommand("Aashil_ProjectUpdate", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@ProjectId", SqlDbType.Int);
        //        cmd.Parameters["@ProjectId"].Value = ID;
        //        con.Open();

        //        SqlDataReader reader = cmd.ExecuteReader();

        //        con.Close();
        //    }
        //    return View("Index");
        //    }
         





        //public ActionResult GetEditTable(Project obj)
        //{
        //    // Retrieve existing dinner
        //    EditTab objRepo = new EditTab();
        //    var edtab = objRepo.GetEditTable(obj);
        //    return OK(edtab);

        //    // Update dinner with form posted values
        //    edtab. = HttpRequest.Form["Title"];
        //    edtab.Description = Request.Form["Description"];
        //    edtab.EventDate = DateTime.Parse(Request.Form["EventDate"]);
        //    edtab.Address = Request.Form["Address"];
        //    edtab.Country = Request.Form["Country"];
        //    edtab.ContactPhone = Request.Form["ContactPhone"];

        //    // Persist changes back to database
        //    dinnerRepository.Save();

        //    // Perform HTTP redirect to details page for the saved Dinner
        //    return RedirectToAction("Details", new { id = dinner.DinnerID });
        //}


    }
}