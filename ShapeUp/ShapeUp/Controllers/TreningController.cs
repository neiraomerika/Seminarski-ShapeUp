using ShapeUp.Interface;
using ShapeUp.Model;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    public class TreningController : BaseCRUDController<MTrening,TreningSearchObject,TreningInsertRequest,TreningUpdateRequest>
    {
        public TreningController(ITreningService service):base(service)
        {

        }
    }
}
