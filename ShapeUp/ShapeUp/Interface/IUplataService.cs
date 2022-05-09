using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Interface
{
    public interface IUplataService
    {
        public bool CreateUplata(bool paid, string chargeId, long? amount);
        public bool SetFinished(int id, bool finished);
    }
}
