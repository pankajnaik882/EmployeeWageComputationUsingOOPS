using System.Linq.Expressions;

namespace EmployeeWageComputationUsingOOPS
{
    public class EmployeeWage
    {
        public static void Main(string[] args)
        {
            CalculateMonthlyHrsWages cmhR = new CalculateMonthlyHrsWages();
            cmhR.montlyWage();
        }
    }
}
