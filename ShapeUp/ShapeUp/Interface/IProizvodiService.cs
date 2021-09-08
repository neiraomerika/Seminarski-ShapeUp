using ShapeUp.Model;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Interface
{
    public interface IProizvodiService : ICRUDService<MProizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
       
    }
}
