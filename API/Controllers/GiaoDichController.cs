﻿using BUS.Service;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/giaodich")]
    [ApiController]
    public class GiaoDichController : ControllerBase
    {
        private readonly IGiaoDichService _service;

        public GiaoDichController(IGiaoDichService service)
        {
            _service = service;
        }

        [HttpGet] 
        public async Task<ActionResult<IEnumerable<GiaoDichTaiChinh>>> GetAll()
        {
            var giaoDich = await _service.GetAllAsync();
            return Ok(giaoDich);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GiaoDichTaiChinh>> GetById(Guid id)
        {
            var giaoDich = await _service.GetByIdAsync(id);
            if (giaoDich == null)
            {
                return NotFound();
            }
            return Ok(giaoDich);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] GiaoDichTaiChinh vm)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
             await _service.AddAsync(vm);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, [FromBody] GiaoDichTaiChinh vm)
        {
            var exxisting = await _service.GetByIdAsync(id);
            if(exxisting == null)
            {
                return NotFound();
            }
            await _service.UpdateAsync(vm); 
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var existing = await _service.GetByIdAsync(id);
            if(existing == null)
            {
                return NotFound();  
            }
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}