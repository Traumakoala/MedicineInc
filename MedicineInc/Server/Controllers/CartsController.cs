using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicineInc.Server.Data;
using MedicineInc.Shared.Domain;
using MedicineInc.Server.IRepository;

namespace MedicineInc.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Carts
        [HttpGet]
        public async Task<IActionResult> GetCarts()
        {
            var Carts = await _unitOfWork.Carts.GetAll();
            return Ok(Carts);
        }

        // GET: api/Carts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCart(int id)
        {
            var Cart = await _unitOfWork.Carts.Get(q => q.Id == id);

            if (Cart == null)
            {
                return NotFound();
            }

            return Ok(Cart);
        }

        // PUT: api/Carts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart(int id, Cart Cart)
        {
            if (id != Cart.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Carts.Update(Cart);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Carts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cart>> PostCart(Cart Cart)
        {

            await _unitOfWork.Carts.Insert(Cart);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCart", new { id = Cart.Id }, Cart);
        }

        // DELETE: api/Carts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            var Cart = await _unitOfWork.Carts.Get(q => q.Id == id);
            if (Cart == null)
            {
                return NotFound();
            }

            await _unitOfWork.Carts.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CartExists(int id)
        {
            var Cart = await _unitOfWork.Carts.Get(q => q.Id == id);
            return Cart != null;

        }
    }
}
