using Microsoft.AspNetCore.Mvc;
using ShapeUp.Interface;
using ShapeUp.Model.Models;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Controllers
{
    public class CiljController : BaseController<MCilj, CiljSearchObject>
    {
        public CiljController (ICiljService service):base(service)
        {

        }
    }
}
