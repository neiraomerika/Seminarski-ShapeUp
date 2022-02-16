using Microsoft.AspNetCore.Mvc;
using ShapeUp.Interface;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    public class MentorstvoController : BaseCRUDController<MMentorstvo, MentorstvoSearchObject, MentorstvoInsertRequest, MentorstvoUpdateRequest>
    {
        public MentorstvoController(IMentorstvoService service):base(service)
        {
        }
    }
}
