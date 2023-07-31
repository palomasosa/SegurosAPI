using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SegurosAPI.Models;

namespace SegurosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetodoPagoController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public MetodoPagoController(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetodoPago>>> GetMetodoPagos()
        {
            if (_dbContext.MetodoPagos == null)
            {
                return NotFound();
            }
            return await _dbContext.MetodoPagos.ToListAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<MetodoPago>> GetMetodoPagoId(int id)
        //{
        //    if (_dbContext.MetodoPagos == null)
        //    {
        //        return NotFound();
        //    }
        //    var metodoPago = await _dbContext.MetodoPagos.Where(x => x.metodoPagoID == id).FirstOrDefaultAsync();
        //    if (metodoPago == null)
        //    {
        //        return NotFound($"No existe un metodo pago de ID= {id}");
        //    }

        //    return Ok(metodoPago);
        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> PostPago(Pagos pago)
        //{
        //    try
        //    {
        //        _dbContext.Pagos.Add(pago);
        //        await _dbContext.SaveChangesAsync();
        //        //Aca nos devuelve el cliente recién creado
        //        return pago.pagoID;
        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }

        //}

        //[HttpPut("{id}")]
        //public async Task<ActionResult<Pagos>> PutPago(int id, Pagos pago)
        //{
        //    if (id != pago.clienteID)
        //    {
        //        return BadRequest();
        //    }
        //    _dbContext.Pagos.Entry(pago).State = EntityState.Modified;
        //    try
        //    {
        //        await _dbContext.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {

        //        throw;
        //    }
        //    return Ok($"Se ha modificado el pago de ID {pago.pagoID}");
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<int>> DeletePago(int id)
        //{
        //    var pago = _dbContext.Pagos.Where(x => x.pagoID == id).FirstOrDefault();
        //    if (pago == null)
        //    {
        //        return NotFound($"No se encontró el pago de Id {id}");
        //    }
        //    try
        //    {
        //        _dbContext.Pagos.Remove(pago);
        //        await _dbContext.SaveChangesAsync();
        //        return Ok($"El registro de  ID: {pago.pagoID} se ha eliminado correctamente");
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest($"Los datos no pudieron ser eliminados por: {e.Message}");
        //    }
        //}
    }
}
