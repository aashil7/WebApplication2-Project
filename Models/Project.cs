using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Project
    {
        public string CustomerName { get; set; }
        public string ProjectName { get; set; }

        public int ProjectId { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }

        public int ProjectStatus { get; set; }

        public int LocationGroup { get; set; }

        public int PayRollState { get; set; }

        public int SalesPerson { get; set; }

        public int ProjectCategory { get; set; }


        public int ProjectType { get; set; }

        public int SubDomain { get; set; }


        public int TimeSheetRepresentative { get; set; }

        public int ClientInvoiceGroup { get; set; }

        public int TimeSheetType { get; set; }

        public int IsVMSTimeSheet { get; set; }
        public int PracticeType { get; set; }

        public int Recruiter { get; set; }

        

    }
}