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
    public async Task<ActionResult<IEnumerable<Shop>>> Get(int lastIdNumber,)
    {
      IQueryable<Shop> query = _db.Shops.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      return await query.ToListAsync()

int nextPage = context.Shops
    .OrderBy(b => b.PostId)
    .Where(b => b.PostId > lastId)
    .Take(10)
    .ToList();
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

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShop(int id)
    {
      Shop shopToDeleteInstance = await _db.Shops.FindAsync(id);
      if (shopToDeleteInstance == null)
      {
        return NotFound();
      }

      _db.Shops.Remove(shopToDeleteInstance);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ShopExists(int id)
    {
      return _db.Shops.Any(e => e.ShopId == id);
    }
  }
}
