using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.API.Data;
using Clinica.API.Models;
using Clinica.API.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Controllers
{
    [Route("api/[controller]")]
    public class EspecialidadesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public EspecialidadesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        

        
        
      
    }
}