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

namespace MedicineInc.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MedicinesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Medicines
        [HttpGet]
        public async Task<IActionResult> GetMedicines()
        {
            var medicines = await _unitOfWork.Medicines.GetAll();
            return Ok(medicines);
        }

        // GET: api/Medicines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedicine(int id)
        {
            var medicine = await _unitOfWork.Medicines.Get(q=>q.Id == id);

            if (medicine == null)
            {
                return NotFound();
            }

            return Ok(medicine);
        }

        // PUT: api/Medicines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicine(int id, Medicine medicine)
        {
            if (id != medicine.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Medicines.Update(medicine);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MedicineExists(id))
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

        // POST: api/Medicines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Medicine>> PostMedicine(Medicine medicine)
        {
             
            await  _unitOfWork.Medicines.Insert(medicine);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMedicine", new { id = medicine.Id }, medicine);
        }

        // DELETE: api/Medicines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicine(int id)
        {
            var medicine = await _unitOfWork.Medicines.Get(q=>q.Id == id);
            if (medicine == null)
            {
                return NotFound();
            }

            await _unitOfWork.Medicines.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MedicineExists(int id)
        {
            var medicine = await _unitOfWork.Medicines.Get(q => q.Id == id);
            return medicine != null;

        }
    }
}
