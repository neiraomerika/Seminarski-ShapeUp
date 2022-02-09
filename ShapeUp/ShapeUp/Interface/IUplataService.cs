using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Interface
{
    public interface IUplataService
    {
        public bool SetPaid(int id, bool paid, string chargeId);
        public bool SetFinished(int id, bool finished);
    }
}
