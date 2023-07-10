using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_LOGISTICA_EF_NET.Models;

namespace API_LOGISTICA_EF_NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaquinasController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public MaquinasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Maquina>>> Get()
        {
            return Ok(await _dataContext.Maquinas.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Maquina>>> Get(int id)
        {
            var maquina = await _dataContext.Maquinas.FindAsync(id);
            if(maquina == null)
                   return NotFound("No se encontro maquina.");
            return Ok(maquina);
        }
        [HttpPost]
        public async Task<ActionResult<List<Maquina>>> CreateMaquina(Maquina m)
        {
            _dataContext.Maquinas.Add(m);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Maquinas.ToListAsync());
        }
    }
}
