using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortlandLocalShopsApi.Models;

namespace CretaceousApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PortlandLocalShopsApiController : ControllerBase
  {
    private readonly PortlandLocalShopsApiContext _db;

    public PortlandLocalShopsApiController(PortlandLocalShopsApiContext db)
    {
      _db = db;
    }

    // get: shops
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shop>>> Get()
    {
      return await _db.Shops.ToListAsync();
    }

    // get: shops/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Shop>> GetShop(int id)
    {
      Shop foundShopInstance = await _db.Shops.FindAsync(id);

      if (foundShopInstance == null)
      {
        return NotFound();
      }

      return foundShopInstance;
    }

    [HttpPost]
    public async Task<ActionResult<Shop>> PostTodoItem(Shop postedShopInstance)
    {
      _db.Shops.Add(postedShopInstance);
      await _db.SaveChangesAsync();

      //    nameof just means: make a string of the action method to avoid hard-coding?
      return CreatedAtAction(nameof(GetShop), new { id = postedShopInstance.ShopId }, postedShopInstance);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutShop(int id, Shop updatedShopInstance)
    {
      if (id != updatedShopInstance.ShopId)
      {
        return BadRequest();
      }

      _db.Shops.Update(updatedShopInstance);

      try
      {
          await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ShopExists(id))
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

    private bool ShopExists(int id)
    {
      return _db.Shops.Any(e => e.ShopId == id);
    }
  }
}
