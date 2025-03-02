using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Employee> Employees { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Employees = _db.Employees.ToList();
        }
    }
}
