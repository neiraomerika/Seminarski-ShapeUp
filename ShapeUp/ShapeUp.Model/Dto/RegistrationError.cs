using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Dto
{
    public class RegistrationError
    {
        public bool RegistrationSuccessful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
