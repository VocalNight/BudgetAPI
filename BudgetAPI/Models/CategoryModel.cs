﻿namespace BudgetAPI.Models
{
    public class CategoryModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<TransactionModel> Transactions { get; set; }
    }
}
