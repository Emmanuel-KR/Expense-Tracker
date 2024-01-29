using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        //CategoryId = FK
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }
        //[Column(TypeName = "varchar (50)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
