using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public class BranchsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        

        public BranchsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Branch
        [HttpGet]
        public async Task<IActionResult> GetBranchs()
        {
            var branchs = await _unitOfWork.Branchs.GetAll();
            return Ok(branchs);
        }

        // GET: api/Branch/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBranch(int id)
        {
            var branch = await _unitOfWork.Branchs.Get(q => q.Id == id);

            if (branch == null)
            {
                return NotFound();
            }

            return Ok(branch);
        }

        // PUT: api/Branch/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch(int id, Branch branch)
        {
            if (id != branch.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Branchs.Update(branch);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BranchExists(id))
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

        // POST: api/Branch
        [HttpPost]
        public async Task<ActionResult<Branch>> PostBranch(Branch branch)
        {
            await _unitOfWork.Branchs.Insert(branch);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBranch", new { id = branch.Id }, branch);
        }

        // DELETE: api/Branch/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            var branch = await _unitOfWork.Branchs.Get(q => q.Id == id);
            if (branch == null)
            {
                return NotFound();
            }

            await _unitOfWork.Branchs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BranchExists(int id)
        {
            var branch = await _unitOfWork.Branchs.Get(q => q.Id == id);
            return branch != null;
        }
    }
}
