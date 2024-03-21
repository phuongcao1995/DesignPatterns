namespace DesignPatterns.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new EmployeeAdapter();
            var data = "[{\"ID\":1,\"Name\":\"Phuong\",\"Designation\":null,\"Salary\":10.0},{\"ID\":2,\"Name\":\"Drake\",\"Designation\":null,\"Salary\":30.0},{\"ID\":3,\"Name\":\"Peter\",\"Designation\":null,\"Salary\":12.0}]";
            target.ProcessCompanySalary(data);
            Console.ReadKey();
        }
    }
}
