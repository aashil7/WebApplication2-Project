using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.repository;
using System.Configuration;


namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
        public SqlConnection con;
        common DB = new common();

        public ActionResult Index()
        {
            common objRepo = new common();

            var appRefStatus = objRepo.GetAppRefData(1800);
            var appRefCategory = objRepo.GetAppRefData(19491);
            var appRefType = objRepo.GetAppRefData(4650);
            var appRefInvoice = objRepo.GetAppRefData(10300);
            var appRefSheetType = objRepo.GetAppRefData(13120);
            var appRefPracticeType = objRepo.GetAppRefData(15760);
            var Rec = objRepo.GetRecrut();
            var domain = objRepo.GetDomain();
            var locgroup = objRepo.GetLocation();
            var timesheetrep = objRepo.GetTimeSheetRep();
            var saleperson = objRepo.GetSalePerson();
            var payroll = objRepo.GetPayRoll();


            var PVM = new ProjectAddEditView
            {
                ProjectStatus = appRefStatus,
                ProjectCategory = appRefCategory,
                ProjectType = appRefType,
                ClientInvoiceGroup = appRefInvoice,
                TimeSheetType = appRefSheetType,
                PracticeType = appRefPracticeType,
                Recruiters = Rec,
                Domains = domain,
                Locationgroup = locgroup,
                TimesheetRepresent = timesheetrep,
                Salesperson = saleperson,
                Payroll = payroll

            };

            return View(PVM);
        }




        //To Add Employee details


        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }



        public ActionResult Add(ProjectAddEditView obj)
        {
            Connection();
            SqlCommand com = new SqlCommand("ProjectView_Ashil_Training", con);
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

                return View("Table");

            }

            return View("Index");

        }



        public ActionResult Tableview()
        {
            return View();
        }



        public ActionResult Table()
        {
            var result = new repository.common().GetProjectsList();
            

            return View(result);
        }


        public ActionResult project()
        {
         
            return View();
        }



         public ActionResult data()
        {
          
            return View();
        }


      


        //public ActionResult GetDetails()
        //{
        //    //var data = DB.tblStuds.ToList();
        //    var data = DB.AppRefData.ToList();
        //    return PartialView(data);
        //}



        //public JsonResult GetAppRefData()
        //{
        //    return Json("",JsonRequestBehavior.AllowGet);
        //}



        //public ActionResult ProjectStatus(int parentId)
        //{
        //    common objRepo = new common();
        //    var appRefStatus = objRepo.GetAppRefData(parentId);
        //    return View(appRefStatus);
        //}




    }
}










//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult TermsAccept()
//{
//    if (ModelState.IsValid)
//    {

//        con.ConnectionString = "Accepted";
//    }
//    return View("Index");
//}






//public ActionResult List()
//{
//    var model = Project.GetList();
//    return View(model);
//}






//public ActionResult Edit(int id)
//{

//    return View(db.GetView().Find(smodel => smodel.Id == id));
//}

//// POST: Student/Edit/5
//[HttpPost]
//public ActionResult Edit(int ID, View Pmodel)
//{
//    try
//    {
//        View db = new View();
//        db.GetView(View,Pmodel);
//        return RedirectToAction("Index");
//    }
//    catch
//    {
//        return View();
//    }
//}



// POST: Student/Create
//[HttpPost]
//public ActionResult Create(ProjectAddEditView Pmodel)
//{
//    try
//    {
//        if (ModelState.IsValid)
//        {
//            common sdb = new common();
//            if (sdb.GetList(Pmodel))
//            {
//                ViewBag.Message = "Student Details Added Successfully";
//                ModelState.Clear();
//            }
//        }
//        return View();
//    }
//    catch
//    {
//        return View();
//    }
//}






















//    public ActionResult Add()
//    {

//    List<Project> ProjectList = new List<Project>();
//    string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
//    con = new SqlConnection(_conString);
//    {
//        SqlCommand cmd = new SqlCommand("ProjectView_Ashil_Training", con);
//        cmd.CommandType = CommandType.Text;
//        con.Open();

//        SqlDataReader rdr = cmd.ExecuteReader();
//        while (rdr.Read())
//        {
//            var Project = new Project();
//            Project.ProjectId = Convert.ToInt32(rdr["ProjectId"]);
//            Project.CustomerName = Convert.ToString(rdr["CustomerName"]);
//            Project.ProjectName = Convert.ToString(rdr["ProjectName"]);
//            Project.ProjectId = Convert.ToInt32(rdr["ProjectId"]);
//            Project.Start_Date = Convert.ToDateTime(rdr["Start_Date"]);
//            Project.End_Date = Convert.ToDateTime(rdr["End_Date"]);
//            Project.ProjectStatus = Convert.ToInt32(rdr["ProjectStatus"]);
//            Project.LocationGroup = Convert.ToInt32(rdr["LocationGroup"]);
//            Project.PayRollState = Convert.ToInt32(rdr["PayRollState"]);
//            Project.SalesPerson = Convert.ToInt32(rdr["SalesPerson"]);
//            Project.ProjectCategory = Convert.ToInt32(rdr["ProjectCategory"]);
//            Project.ProjectType = Convert.ToInt32(rdr["ProjectType"]);
//            Project.SubDomain = Convert.ToInt32(rdr["SubDomain"]);
//            Project.TimeSheetRepresentative = Convert.ToInt32(rdr["TimeSheetRepresentative"]);
//            Project.ClientInvoiceGroup = Convert.ToInt32(rdr["ClientInvoiceGroup"]);
//            Project.TimeSheetType = Convert.ToInt32(rdr["TimeSheetType"]);
//            Project.IsVMSTimeSheet = Convert.ToInt32(rdr["IsVMSTimeSheet"]);
//            Project.PracticeType = Convert.ToInt32(rdr["PracticeType"]);
//            Project.Recruiter = Convert.ToInt32(rdr["Recruiter"]);



//        }
//    }
//    return View(ProjectList);
//}



