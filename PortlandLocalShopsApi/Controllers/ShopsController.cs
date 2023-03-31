using Microsoft.AspNetCore.Mvc;
using PortlandLocalShopsApi.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;

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
    public async Task<ActionResult<IEnumerable<Shop>>> Get(string name)
    {
      IQueryable<Shop> query = _db.Shops.AsQueryable();
      if ( name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      return await query.ToListAsync();
//
//      if (name != null)
//      {
//        query = query.Where(entry => entry.Name == name);
//      }
//      var queryResults = await query.ToListAsync();
//      var pagedResults = Paginate(lastIdNumber, queryResults);
//      return pagedResults;

    }

//    private IEnumerable<Shop> Paginate(int lastIdNumber, IEnumerable<Shop> queryResults)
//    {
//      IEnumerable<Shop> nextPage = queryResults
//        .OrderBy(b => b.ShopId)
//        .Where(b => b.ShopId > lastIdNumber)
//        .Take(2)
//        .ToList();
//      return nextPage;
//    }

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
