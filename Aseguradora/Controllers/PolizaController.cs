using Aseguradora.Context;
using Aseguradora.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Aseguradora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PolizaController : ControllerBase
    {
        private readonly AseguradoraContext _dbContext;

        public PolizaController()
        {
        }

        public PolizaController(AseguradoraContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Poliza>>> GetPoliza()
        {
            if (_dbContext.Polizas == null)
            {
                return NotFound();
            }
            return await _dbContext.Polizas.ToListAsync();
        }

        [HttpGet("{NumeroPoliza}")]
        public async Task<ActionResult<Poliza>> GetPoliza(int numeroPoliza)
        {
            if (_dbContext.Polizas == null)
            {
                return NotFound();
            }
            var poliza = await _dbContext.Polizas.FindAsync(numeroPoliza);

            if (poliza == null)
            {
                return NotFound();
            }
            return poliza;
        }

        [HttpGet("{IdentificacionCliente}")]
        public async Task<ActionResult<Poliza>> GetPolizaCliente(int IdentificacionCliente)
        {
            if (_dbContext.Polizas == null)
            {
                return NotFound();
            }
            var poliza = await _dbContext.Polizas.FindAsync(IdentificacionCliente);

            if (poliza == null)
            {
                return NotFound();
            }
            return poliza;
        }
        

        [HttpPost]
        public async Task<ActionResult<Poliza>> PostPoliza(Poliza poliza)
        {
            DateTime hoy = DateTime.Today;
            DateTime fechaini1 = Convert.ToDateTime(poliza.FechaPoliza, new CultureInfo("es-ES"));

            _dbContext.Polizas.Add(poliza);
            await _dbContext.SaveChangesAsync();


            if (DateTime.Compare(fechaini1, hoy) > 0)
            {
                return CreatedAtAction(nameof(GetPoliza), new { id = poliza.Id }, poliza);
            }
            else {
                return StatusCode(StatusCodes.Status404NotFound);
            }

           
        }

    }
}
