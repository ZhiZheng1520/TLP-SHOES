using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TLPShoes.Data;
using TLPShoes.Models;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace TLPShoes.Controllers
{
    public class SupplierController : Controller
    {
        private readonly TLPShoesContext _dbContext;
		private readonly TLPShoesContext _context;
		private readonly IWebHostEnvironment _environment;

        public SupplierController(TLPShoesContext dbContext, IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        private async Task LoadApprovalCounts()
        {
            ViewBag.PendingCount = await _dbContext.Supply_Form.CountAsync(x => x.approval_status == "pending");
            ViewBag.ApprovedCount = await _dbContext.Supply_Form.CountAsync(x => x.approval_status == "approved");
            ViewBag.DeclinedCount = await _dbContext.Supply_Form.CountAsync(x => x.approval_status == "declined");
        }

        public IActionResult Index()
        {
            return View(new Supply_Form());
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult EditProfile()
        {
            return View();
        }

        public async Task<IActionResult> ProductList(int page = 1, int pageSize = 10)
        {
            await LoadApprovalCounts();

            var supplyForms = await _dbContext.Supply_Form
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)await _dbContext.Supply_Form.CountAsync() / pageSize);

            return View(supplyForms);
        }

        public async Task<IActionResult> FilterProducts(string? status = null)
        {
            await LoadApprovalCounts();

            IQueryable<Supply_Form> query = _dbContext.Supply_Form;
            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(x => x.approval_status == status);
            }

            var supplyForm = await query.FirstOrDefaultAsync();
            return View(supplyForm);
        }

        public async Task<IActionResult> ProductListAdd()
        {
            var supplyForm = await _dbContext.Supply_Form.FirstOrDefaultAsync();
            return View(supplyForm);
        }


		public async Task<IActionResult> ProductListPending()
        {
            await LoadApprovalCounts();

            List<Supply_Form> supplyForms = await _dbContext.Supply_Form
                .Where(x => x.approval_status == "pending")
                .ToListAsync();

            return View(supplyForms);
        }

        public async Task<IActionResult> ProductListLive()
        {
            await LoadApprovalCounts();

            List<Supply_Form> supplyForms = await _dbContext.Supply_Form
                .Where(x => x.approval_status == "approved")
                .ToListAsync();

            return View(supplyForms);
        }

        public async Task<IActionResult> ProductListDeclined()
        {
            {
                await LoadApprovalCounts();

                List<Supply_Form> supplyForms = await _dbContext.Supply_Form
                    .Where(x => x.approval_status == "declined")
                    .ToListAsync();

                return View(supplyForms);
            }
        }

		//delete data from the page
		public async Task<IActionResult> DeleteSupplyData(string sku)
		{
			if (sku == null)
			{
				return NotFound();
			}

			var Supply_Form = await _dbContext.Supply_Form.FindAsync(sku);

			if (Supply_Form == null)
			{
				return BadRequest(sku + " is not found in the list!");
			}

			_dbContext.Supply_Form.Remove(Supply_Form);
			await _dbContext.SaveChangesAsync();
			return RedirectToAction("ProductListLive", "Supplier");
		}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddData(Supply_Form Supply_Form)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Supply_Form);  // Adds the new flower to the database
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));  // Redirect to the index page to show updated list
            }
            return View(Supply_Form);  // If model is invalid, return to the form with the entered data
        }


    }


}
