﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicineInc.Server.Data;
using MedicineInc.Shared.Domain;
using MedicineInc.Server.IRepository;

namespace CartInc.Server.Controllers
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

        // GET: api/carts
        [HttpGet]
        public async Task<IActionResult> GetCarts()
        {
            var carts = await _unitOfWork.Carts.GetAll(includes: q => q.Include(x => x.Customer));
            return Ok(carts);
        }

        // GET: api/Carts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCart(int id)
        {
            var cart = await _unitOfWork.Carts.Get(q => q.Id == id);
            
            if (cart == null)
            {
                return NotFound();
            }

            return Ok(cart);
        }

        // PUT: api/Carts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart(int id, Cart cart)
        {

            _unitOfWork.Carts.Update(cart);

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
        public async Task<ActionResult<Cart>> PostCart(Cart cart)
        {

            await _unitOfWork.Carts.Insert(cart);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCart", new { id = cart.Id }, cart);
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
