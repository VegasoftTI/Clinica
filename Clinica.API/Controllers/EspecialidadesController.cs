using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinica.API.Data;
using Clinica.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Controllers
{
      [Route("api/[controller]")]
    public class EspecialidadesController : Controller
    {
        private readonly DataContexto _contexto;

        public EspecialidadesController(DataContexto contexto)
        {
            _contexto = contexto;
        }
        
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var especialidades = await _contexto.Especialidades.ToListAsync();
            return Ok(especialidades);

        }
      
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var especialidade = await _contexto.Especialidades.FirstOrDefaultAsync(x => x.ID == id);
            return Ok(especialidade);
        }
        
        // GET api/values/5       
        /*   [HttpGet("{id}")]
        public string Get(int id)
        {
            return Lista[id];
        } */

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Especialidade especialidade)
        {
            await _contexto.Especialidades.AddAsync(especialidade);
            await _contexto.SaveChangesAsync();
            
             return Ok(especialidade);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Especialidade especialidade)
        {
            var _especialidade = await _contexto.Especialidades.FirstOrDefaultAsync(x => x.ID == id);

           if(_especialidade == null) 
                return NotFound();

            _especialidade.Nome = especialidade.Nome;
            _especialidade.Ativo = especialidade.Ativo;
            _especialidade.DataCriacao = especialidade.DataCriacao;

            //await _contexto.Especialidades.
            await _contexto.SaveChangesAsync();
            
             return Ok(especialidade);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var _especialidade =  _contexto.Especialidades.FirstOrDefault(x => x.ID == id);

           if(_especialidade == null) 
                return NotFound();

             _contexto.Especialidades.Remove(_especialidade);
             _contexto.SaveChanges();
            
             return Ok();
        }

    }
}