using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Employee Employee { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Employee = _db.Employees.Find(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Employees.Update(Employee);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
