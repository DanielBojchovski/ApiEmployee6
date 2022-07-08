using ApiEmployee6.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmployee6.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeContext _context;

        public DepartmentRepository(EmployeeContext context)
        {
            _context = context;
        }
        public async Task<Department> GetDepartment(int departmentId)
        {
            return await _context.Departments.FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }
    }
}
