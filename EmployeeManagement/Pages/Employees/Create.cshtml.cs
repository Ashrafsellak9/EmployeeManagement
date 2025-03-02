using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Employee Employee { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Employees.Add(Employee);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
        
    }
}
