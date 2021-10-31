using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BCM_LeadGen.Models
{
    public partial class LeadGeneration
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="กรุณากรอกชื่อ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "กรุณากรอกนามสกุล")]
        public string Surname { get; set; }
        public string LineId { get; set; }
        [Required(ErrorMessage = "กรุณากรอกอีเมล")]
        public string Email { get; set; }
        [Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "กรุณากรอกรุ่นรถที่สนใจ")]
        public string CarModel { get; set; }
        [Required(ErrorMessage = "กรุณาเลือกระยะเวลา")] 
        public string NextCarTime { get; set; }
        [Required(ErrorMessage = "กรุณาเลือกสาขา")]
        public string Branch { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
