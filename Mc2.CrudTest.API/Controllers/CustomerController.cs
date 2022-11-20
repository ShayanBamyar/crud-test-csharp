using Mc2.CrudTest.Domain.Entities;
using Mc2.CrudTest.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Mc2.CrudTest.API.Controllers
{
    [Route("Customer/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly RepositoryDbContext _context;

        public CustomerController(RepositoryDbContext context)
        {
            _context = context;
        }
        [Route("Show")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomerRegistration.ToListAsync());
        }
        [Route("Details")]
        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null || _context.CustomerRegistration == null)
            {
                return NotFound();
            }

            var customer = await _context.CustomerRegistration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
        [Route("Create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [Route("Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Creat(CustomerBase customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return Ok(customer);

            }
            catch
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(string.Format("Some thing wrong")),
                    ReasonPhrase = "Product ID Not Found"
                };
                return BadRequest(resp);
            }
        }

        [Route("Edit")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null || _context.CustomerRegistration == null)
            {
                return NotFound();
            }

            var customer = await _context.CustomerRegistration.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [Route("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, CustomerBase customer)
        {
            try
            {
                if (id != customer.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(customer);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CustomerExists(customer.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return Ok(customer);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Route("Delete")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CustomerRegistration == null)
            {
                return NotFound();
            }

            var customer = await _context.CustomerRegistration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [Route("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                if (_context.CustomerRegistration == null)
                {
                    return Problem("Entity set 'CustomDbContext.CustomerRegistration'  is null.");
                }
                var customer = await _context.CustomerRegistration.FindAsync(id);
                if (customer != null)
                {
                    _context.CustomerRegistration.Remove(customer);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return BadRequest();
            }
        }
        private bool CustomerExists(Guid id)
        {
            return _context.CustomerRegistration.Any(e => e.Id == id);
        }
    }
}
