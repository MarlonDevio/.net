namespace BudgetTracker.Classes.Budget;

public class Budget
{
   private double _budgetAmount;
   private string _budgetName;

   public Budget(string budgetName)
   {
      _budgetName = budgetName;
   }
   public Budget(double budget, string budgetName)
   {
      this._budgetAmount = budget;
      this._budgetName = budgetName;
   }

   public double Budget1
   {
      get => _budgetAmount;
      set => _budgetAmount = value;
   }

   public string BudgetName
   {
      get => _budgetName;
      set => _budgetName = value ?? throw new ArgumentNullException(nameof(value));
   }
}