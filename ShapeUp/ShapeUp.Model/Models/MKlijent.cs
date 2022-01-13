using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MKlijent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public byte[] Picture { get; set; }
        public DateTime SignUpDate { get; set; }
        public List<MMentorstvo> Mentorships { get; set; }
        public List<MUplata> Uplate { get; set; }
    }
}
