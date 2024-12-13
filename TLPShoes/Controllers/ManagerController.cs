using TLPShoes.Data;
using TLPShoes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Data.SqlTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TLPShoes.Controllers
{
	public class ManagerController : Controller
	{
		private readonly TLPShoesContext _context;

		public ManagerController(TLPShoesContext context)
		{
			_context = context;
		}


		public async Task<IActionResult> Index()
		{
            // Fetch Supply_Form
            var Supply_Form = await _context.Supply_Form.ToListAsync();

            // Calculate counts for each approval status
            var pendingCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "pending");
            var approvedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "approved");
            var declinedCount = await _context.Supply_Form.CountAsync(x => x.approval_status == "declined");

            // Get all users
            var users = await _context.Users.ToListAsync();

            // Calculate counts for each user role
            var managerCount = await _context.Users.CountAsync(x => x.Role == "Manager");
            var customerCount = await _context.Users.CountAsync(x => x.Role == "Customer");
            var supplierCount = await _context.Users.CountAsync(x => x.Role == "Supplier");

            // Calculate counts for each payment
            var debitcreditCount = await _context.Order.CountAsync(x => x.payment_method == "Debit/Credit Card");
            var cashCount = await _context.Order.CountAsync(x => x.payment_method == "Cash");
            var eWalletCount = await _context.Order.CountAsync(x => x.payment_method == "E-wallet");

            // Create ViewModel
            var model = new ManagerIndex
			{
				Supply_Form = Supply_Form,
				TLPShoesUser = users,
				PendingCount = pendingCount,
				ApprovedCount = approvedCount,
				DeclinedCount = declinedCount,
				ManagerCount = managerCount,
				CustomerCount = customerCount,
				SupplierCount = supplierCount,
                debitcreditCount = debitcreditCount,
                cashCount = cashCount,
                eWalletCount = eWalletCount,
                
            };

            return View(model);
        }


		public async Task<IActionResult> DiscountLogic()
		{
			// Fetch Supply_Form
			var Discount_Logic = await _context.Discount_Logic.ToListAsync();

			return View(Discount_Logic);
		}

		public async Task<IActionResult> EditDiscountLogic(string? dlu)
		{

			if (dlu == null)
			{
				return NotFound();
			}
			var Discount_Logic = await _context.Discount_Logic.FindAsync(dlu);

			if (Discount_Logic == null)
			{
				return BadRequest(dlu + " is not found in the table!");
			}

			return View(Discount_Logic);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> UpdateData(Discount_Logic Discount_Logic)
		{
			try
			{
				if (ModelState.IsValid)
				{
					_context.Discount_Logic.Update(Discount_Logic);
					await _context.SaveChangesAsync();
					return RedirectToAction("DiscountLogic", "Manager");
				}
				return View("DiscountLogic", Discount_Logic);
			}
			catch (Exception ex)
			{
				return BadRequest("Error: " + ex.Message);
			}
		}

		public async Task<IActionResult> StockManagement()
		{
			// Fetch Supply_Form
			var Inventory = await _context.Inventory.ToListAsync();

			return View(Inventory);
		}

		public async Task<IActionResult> PriceApproval()
		{
			// Fetch Supply_Form
			var Supply_Form = await _context.Supply_Form.ToListAsync();

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

			// Fetch Supply_Form
			var Supply_Form = await _context.Supply_Form.ToListAsync();

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
			// Fetch Supply_Form
			var Supply_Form = await _context.Supply_Form.ToListAsync();

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
			// Fetch Supply_Form
			var Supply_Form = await _context.Supply_Form.ToListAsync();

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

		[HttpPost]
		public async Task<IActionResult> ApproveStatus(string sku)
		{
			// Find the item by SKU
			var supplyForm = await _context.Supply_Form.FirstOrDefaultAsync(s => s.sku == sku);

			if (supplyForm == null)
			{
				return NotFound(); // Return NotFound if the item is not found
			}

			// Update the approval status to "Approved"
			supplyForm.approval_status = "approved";

			// Save changes to the database
			_context.Update(supplyForm);
			await _context.SaveChangesAsync();

			// Redirect back to PriceApprovalManagement
			return RedirectToAction("PriceApproval");
		}

		[HttpPost]
		public async Task<IActionResult> DeclineStatus(string sku)
		{
			// Fetch the stock details
			var stockDetails = await _context.Supply_Form.FirstOrDefaultAsync(s => s.sku == sku);

			if (stockDetails == null)
			{
				return NotFound("The specified item was not found.");
			}

			// Update the approval status
			stockDetails.approval_status = "declined";
			_context.Update(stockDetails);

			// Save changes to the database
			await _context.SaveChangesAsync();
			return RedirectToAction("PriceApproval");
		}

		//delete data from the page
		public async Task<IActionResult> DeleteInventoryData(string ivt)
		{
			if (ivt == null)
			{
				return NotFound();
			}

			var iventory_item = await _context.Inventory.FindAsync(ivt);

			if (iventory_item == null)
			{
				return BadRequest(ivt + " is not found in the list!");
			}

			_context.Inventory.Remove(iventory_item);
			await _context.SaveChangesAsync();
			return RedirectToAction("StockManagement", "Manager");
		}
	}
}