using AutoMapper;
using ShapeUp.Database;
using ShapeUp.Interface;
using ShapeUp.Model.Models;
using ShapeUp.Model.Request;
using ShapeUp.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeUp.Service
{
    public class PlanPrehraneService : BaseCRUDService<MPlanPrehrane, PlanPrehraneSearchObject, PlanPrehrane, PlanPrehraneInsertRequest, PlanPrehraneUpdateRequest>, IPlanPrehraneService
    {
        private readonly ShapeUpDBContext _context;
        private readonly IMapper _mapper;

        public PlanPrehraneService(ShapeUpDBContext context,
                                   IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
