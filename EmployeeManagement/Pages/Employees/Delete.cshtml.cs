using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Employee Employee { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Employee = _db.Employees.Find(id);
        }
        public IActionResult OnPost()
        {
            _db.Employees.Remove(Employee);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
