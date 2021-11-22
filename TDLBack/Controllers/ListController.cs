using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDLBack.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TDLBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        public readonly ApplicationDBContext _context;

        public ListController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/<ListController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var list = await _context.Lista.ToListAsync();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST api/<ListController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Lista item)
        {
            try
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return Ok(item);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ListController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Lista item)
        {
            try
            {
                if(id != item.Id)
                {
                    return NotFound();
                }
                _context.Update(item);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Item Updated" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ListController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var item = await _context.Lista.FindAsync(id);

                if (item == null)
                {
                    return NotFound();
                }
               
                _context.Lista.Remove(item);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Item Deleted" });
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
