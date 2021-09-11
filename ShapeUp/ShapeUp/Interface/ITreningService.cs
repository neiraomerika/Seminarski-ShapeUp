using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShapeUp.Model;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;

namespace ShapeUp.Interface
{
    public interface ITreningService :ICRUDService<MTrening,TreningSearchObject,TreningInsertRequest,TreningUpdateRequest>
    {
    }
}
