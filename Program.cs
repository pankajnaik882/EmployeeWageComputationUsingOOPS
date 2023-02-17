using System.Linq.Expressions;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            CalculateMonthlyWages cm = new CalculateMonthlyWages();
            cm.montlyWage();
        }
    }
}
