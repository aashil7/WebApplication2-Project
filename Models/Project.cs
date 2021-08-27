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
        public int? ProjectId { get; set; }



        [Required(ErrorMessage = "Please Select Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public string Start_Date { get; set; }


        [Required(ErrorMessage = "Please Select Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yy}")]
        public string End_Date { get; set; }



        [Required(ErrorMessage = "Please Select Project Status")]
        public int? ProjectStatus { get; set; }



        [Required(ErrorMessage = "Please Select Location Group")]
        public int? LocationGroup { get; set; }


        [Required(ErrorMessage = "Please Select Payroll State")]
        public int? PayRollState { get; set; }

        [Required(ErrorMessage = "Please Select Sales Person")]
        public int? SalesPerson { get; set; }

        [Required(ErrorMessage = "Please Select ProjectCategory")]
        public int? ProjectCategory { get; set; }

        [Required(ErrorMessage = "Please Select Project Type")]
        public int? ProjectType { get; set; }

        [Required(ErrorMessage = "Please Select Sub Domain")]
        public int? SubDomain { get; set; }

        [Required(ErrorMessage = "Please Select Timesheet Representative")]
        public int? TimeSheetRepresentative { get; set; }

        [Required(ErrorMessage = "Please Select Client Invoice Group")]
        public int? ClientInvoiceGroup { get; set; }

        [Required(ErrorMessage = "Please Select TimeSheet Type")]
        public int? TimeSheetType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide VMS Timesheet")]
        public int? IsVMSTimeSheet { get; set; }


        [Required(ErrorMessage = "Please Select Practice Type")]
        public int? PracticeType { get; set; }


        [Required(ErrorMessage = "Please Select Recruiter")]
        public int? Recruiter { get; set; }


        
    }
}