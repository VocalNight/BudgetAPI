namespace BudgetAPI.Models
{
    public class TransactionModel
    {
        public long Id {  get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public long? CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
