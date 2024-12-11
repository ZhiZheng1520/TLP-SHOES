using TLPShoes.Data;
using TLPShoes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;

namespace TLPShoes.Controllers
{
	public class ManagerController : Controller
	{
		private readonly TLPShoesContext _context;

		public ManagerController(TLPShoesContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult StockManagement()
		{
			return View();
		}

		public async Task<IActionResult> PriceApproval()
		{
			// Fetch Supply_Form along with related Supply_Details
			var Supply_Form = await _context.Supply_Form.Include(s => s.Supply_Details).ToListAsync();

			// Calculate counts for each approval status
			var pendingCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "pending");
			var approvedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "approved");
			var declinedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "declined");

			// Pass data to the view using ViewBag or ViewData
			ViewBag.PendingCount = pendingCount;
			ViewBag.ApprovedCount = approvedCount;
			ViewBag.DeclinedCount = declinedCount;

			return View(Supply_Form);
		}

		// Action to display PriceApprovalManagement view with stock details
		public async Task<IActionResult> PriceApprovalPending()
		{

			List<Supply_Form> Supply_Form = await _context.Supply_Form.ToListAsync();

			// Calculate counts for each approval status
			var pendingCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "pending");
			var approvedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "approved");
			var declinedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "declined");

			// Pass data to the view using ViewBag or ViewData
			ViewBag.PendingCount = pendingCount;
			ViewBag.ApprovedCount = approvedCount;
			ViewBag.DeclinedCount = declinedCount;

			// Pass stock details list
			return View(Supply_Form);
		}

		public async Task<IActionResult> PriceApprovalApprove()
		{
			List<Supply_Form> Supply_Form = await _context.Supply_Form.ToListAsync();

			// Calculate counts for each approval status
			var pendingCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "pending");
			var approvedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "approved");
			var declinedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "declined");

			// Pass data to the view using ViewBag or ViewData
			ViewBag.PendingCount = pendingCount;
			ViewBag.ApprovedCount = approvedCount;
			ViewBag.DeclinedCount = declinedCount;

			return View(Supply_Form);
		}

		public async Task<IActionResult> PriceApprovalDeclined()
		{
			List<Supply_Form> Supply_Form = await _context.Supply_Form.ToListAsync();

			// Calculate counts for each approval status
			var pendingCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "pending");
			var approvedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "approved");
			var declinedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "declined");

			// Pass data to the view using ViewBag or ViewData
			ViewBag.PendingCount = pendingCount;
			ViewBag.ApprovedCount = approvedCount;
			ViewBag.DeclinedCount = declinedCount;

			return View(Supply_Form);
		}

        public IActionResult DeclinedForm()
        {
            return View();
        }

		// Action to approve an item
		[HttpPost]
		public async Task<IActionResult> ApproveStatus(string Sku)
		{
			// Find the item by Sku
			string skuString = Sku.ToString();  // Convert the integer Sku to a string

			var Supply_Form = await _context.Supply_Form.FirstOrDefaultAsync(s => s.sku == skuString);

			if (Supply_Form == null)
			{
				return NotFound(); // Return NotFound if the item is not found
			}

			// Update the approval status to "Approved"
			Supply_Form.approval_status = "approved";

			// Save changes to the database
			_context.Update(Supply_Form);
			await _context.SaveChangesAsync();

			// Redirect back to PriceApprovalManagement
			return RedirectToAction("PriceApproval");
		}

		[HttpPost]
		public async Task<IActionResult> DeclineStatus(string sku)
		{

			// Find the item by Sku
			string skuString = sku.ToString();  // Convert the integer Sku to a string
												// Fetch the Supply_Form based on SKU
			var stockDetails = await _context.Supply_Form.FirstOrDefaultAsync(s => s.sku == skuString);

			if (stockDetails == null)
			{
				return NotFound(); // Return 404 NotFound if the item is not found
			}

			// Update the approval status to "Declined"
			stockDetails.approval_status = "declined";

			// Save changes to the database
			_context.Update(stockDetails);
			await _context.SaveChangesAsync();

			// Redirect back to PriceApproval
			return RedirectToAction("PriceApproval");
		}
	}
}
