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
    public class KategTreningaController : BaseController<MKategorijaTreninga, KategTreningaSearchObject>
    {
        public KategTreningaController (IKategTreningaService service):base(service)
        {

        }
    }
}
