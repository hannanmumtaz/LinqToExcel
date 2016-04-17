using System;
using LinqToExcel.Attributes;

namespace UnitTestProject1
{
    public class CompanyWithColumnAnnotations
    {
        [ExcelColumn("Company Title")]
        public string Name { get; set; }

        [ExcelColumn("Boss")]
        public string CEO { get; set; }
        
        [ExcelColumn("Number of People")]
        public int EmployeeCount { get; set; }

        [ExcelColumn("Initiation Date")]
        public DateTime StartDate { get; set; }

        [ExcelColumn("Active")]
        public string IsActive { get; set; }
    }
}
