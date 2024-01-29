using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        public string Title { get; set; }
        
        public string Icon { get; set; } = "";
       // [Column(TypeName = "varchar (10)")] 
        public string Type { get; set; } = "Expense";

    }
}
