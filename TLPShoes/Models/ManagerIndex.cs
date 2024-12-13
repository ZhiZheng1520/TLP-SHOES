

using Microsoft.AspNetCore.Identity;
using TLPShoes.Areas.Identity.Data;

namespace TLPShoes.Models
{
    public class ManagerIndex
    {
        public List<Supply_Form> Supply_Form { get; set; }
        public List<TLPShoesUser> TLPShoesUser { get; set; }
        public List<Order> Order { get; set; }

        // Count number of stock form
        public int PendingCount { get; set; }
        public int ApprovedCount { get; set; }
        public int DeclinedCount { get; set; }

        // Count Number of Users
        public int ManagerCount { get; set; }
        public int CustomerCount { get; set; }
        public int SupplierCount { get; set; }

        // Revenue by Payment Method (Dictionary to store payment method and corresponding revenue)
        public int debitcreditCount { get; set; }
        public int cashCount { get; set; }
        public int eWalletCount { get; set; }

        // Constructor to Initialize Lists
        public ManagerIndex()
        {
            Supply_Form = new List<Supply_Form>();
            TLPShoesUser = new List<TLPShoesUser>();
            Order = new List<Order>();
        }
    }
}
