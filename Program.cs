using System.Linq.Expressions;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            CalculateMonthlyHrsWages cmh = new CalculateMonthlyHrsWages();
            cmh.montlyWage();
        }
    }
}
