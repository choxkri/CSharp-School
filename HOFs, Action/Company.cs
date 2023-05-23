public class Company
{
    private List<Employee> _employees { get; } = new();
    public void HireEmployee(Employee emp) => _employees.Add(emp);

    // FilterEmployees goes here
    public List<Employee> FilterEmployees(Func<Employee, bool> lam)
    {
        List<Employee> employees = new();
        foreach(Employee emp in _employees.Where(lam))
        {
            employees.Add(emp);
        }
        return employees;
    }
}