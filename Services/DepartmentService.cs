using EmployeeFluentBlazor.Data;
using EmployeeFluentBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

namespace EmployeeFluentBlazor.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly EmployeeDbContext _context;

        public DepartmentService(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task AddDepartmentAsync(Department entity)
        {
            await _context.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteDepartmentAsync(Guid Id)
        {
            var entity = await _context.Departments.SingleOrDefaultAsync(c => c.Id == Id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            var result = await _context.Departments.ToListAsync();

            return result;
        }

        public async Task<Department> GetDepartmentByIdAsync(Guid Id)
        {
            var result = await _context.Departments.Where(d => d.Id == Id).FirstOrDefaultAsync();

            return result;
        }

        public async Task UpdateDepartmentAsync(Department entity)
        {
            var model = await _context.Departments.Where(d => d.Id == entity.Id).FirstOrDefaultAsync();

            model.Id = entity.Id;
            model.Name = entity.Name;
            model.CreatedOn = DateTime.Now;

            _context.Departments.Update(model);
            await _context.SaveChangesAsync();
        }
    }

    public interface IDepartmentService
    {
        Task<List<Department>> GetAllDepartmentsAsync();
        Task<Department> GetDepartmentByIdAsync(Guid Id);
        Task UpdateDepartmentAsync(Department entity);
        Task AddDepartmentAsync(Department entity);
        Task DeleteDepartmentAsync(Guid Id);
    }
}
