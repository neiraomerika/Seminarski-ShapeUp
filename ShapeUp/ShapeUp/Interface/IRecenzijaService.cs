using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;

namespace ShapeUp.Interface
{
    public interface IRecenzijaService : ICRUDService<MRecenzija, RecenzijaSearchObject, RecenzijaInsertRequest, RecenzijaUpdateRequest>
    {
    }
}
