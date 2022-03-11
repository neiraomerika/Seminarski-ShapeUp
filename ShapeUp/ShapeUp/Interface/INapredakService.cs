using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Interface
{
    public interface INapredakService : ICRUDService<MNapredak, NapredakSearchObject, NapredakInsertRequest, NapredakUpdateRequest>
    {
    }
}
