
using Newtonsoft.Json;

namespace DesignPatterns.Adapter
{
    internal class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string data)
        {
            var listEmployee = JsonConvert.DeserializeObject<List<Employee>>(data);

            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}
