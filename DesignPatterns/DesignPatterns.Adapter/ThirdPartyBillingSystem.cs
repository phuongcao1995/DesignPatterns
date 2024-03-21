namespace DesignPatterns.Adapter
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} : {employee.Salary}");
            }
        }
    }
}
