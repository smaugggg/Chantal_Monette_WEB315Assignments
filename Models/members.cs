using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamcatcherMembers.Models
{
    public class Member
    {
        public int ID { get; set; }
        [Display(Name = "Stage Name")]
        public string stageName { get; set; }
        [Display(Name = "Full Name")]
        public string fullName { get; set; }
        [Display(Name = "English Name")]
        public string englishName { get; set; }
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        public DateTime birthday { get; set; }
        [Display(Name = "Role")]
        public string role { get; set; }
        [Display(Name = "Home Town")]
        public string homeTown { get; set; }

    }
}