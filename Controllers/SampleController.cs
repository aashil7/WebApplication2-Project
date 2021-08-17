using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.repository;

namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
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
                ProjectCategory = appRefCategory ,
                ProjectType = appRefType ,
                ClientInvoiceGroup = appRefInvoice ,
                TimeSheetType = appRefSheetType,
                PracticeType = appRefPracticeType,
                Recruiters=Rec,
                Domains=domain,
                Locationgroup=locgroup,
                TimesheetRepresent=timesheetrep,
                Salesperson = saleperson,
                Payroll =payroll
               
            };

            return View(PVM);
        }

    }
}