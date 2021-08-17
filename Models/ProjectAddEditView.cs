
using System.Collections.Generic;


namespace WebApplication2.Models
{
    public class ProjectAddEditView
    {
        public Project  Project { get; set; }

        public List<AppRefData> ProjectStatus { get; set; }


        public List<AppRefData> ProjectCategory { get; set; }


        public List<AppRefData> ProjectType { get; set; }


        public List<AppRefData> ClientInvoiceGroup { get; set; }

        public List<AppRefData> TimeSheetType { get; set; }

        
        public List<AppRefData> PracticeType { get; set; }


        public List<Projlist> Recruiters { get; set; }

        public List<Projlist> Domains { get; set; }

        public List<Projlist> Locationgroup { get; set; }

        public List<Projlist> TimesheetRepresent { get; set; }

        public List<Projlist> Salesperson { get; set; }

        public List<Projlist> Payroll { get; set; }

    }
}