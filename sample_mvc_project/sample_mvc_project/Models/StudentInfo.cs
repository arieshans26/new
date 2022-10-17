using System;
namespace sample_mvc_project.Models
{
    public class StudentInfo
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Course { get; set; }
        public bool IsEnrolled { get; set; }


        public string? Secret { get; set; }
    }
}

