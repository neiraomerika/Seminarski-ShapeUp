using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MKlijent
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Active { get; set; }
        public byte[] Picture { get; set; }
        public DateTime SignUpDate { get; set; }
        public List<MPlan> Plans { get; set; }
    }
}
