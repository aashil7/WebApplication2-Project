using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Project
    {
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name Should be min 3 and max 20 length")]
        public string CustomerName { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide ProjectName")]
        public string ProjectName { get; set; }



        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide ProjectId")]
        public string ProjectId { get; set; }



        [Required(ErrorMessage = "Please Select Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public string Start_Date { get; set; }


        [Required(ErrorMessage = "Please Select Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public string End_Date { get; set; }



        [Required(ErrorMessage = "Please Select Project Status")]
        public string ProjectStatus { get; set; }



        [Required(ErrorMessage = "Please Select Location Group")]
        public string LocationGroup { get; set; }


        [Required(ErrorMessage = "Please Select Payroll State")]
        public string PayRollState { get; set; }

        [Required(ErrorMessage = "Please Select Sales Person")]
        public string SalesPerson { get; set; }

        [Required(ErrorMessage = "Please Select ProjectCategory")]
        public string ProjectCategory { get; set; }

        [Required(ErrorMessage = "Please Select Project Type")]
        public string ProjectType { get; set; }

        [Required(ErrorMessage = "Please Select Sub Domain")]
        public string SubDomain { get; set; }

        [Required(ErrorMessage = "Please Select Timesheet Representative")]
        public string TimeSheetRepresentative { get; set; }

        [Required(ErrorMessage = "Please Select Client Invoice Group")]
        public string ClientInvoiceGroup { get; set; }

        [Required(ErrorMessage = "Please Select TimeSheet Type")]
        public string TimeSheetType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide VMS Timesheet")]
        public string IsVMSTimeSheet { get; set; }


        [Required(ErrorMessage = "Please Select Practice Type")]
        public string PracticeType { get; set; }


        [Required(ErrorMessage = "Please Select Recruiter")]
        public string Recruiter { get; set; }


        //public int ID { get; set; }
    }
}