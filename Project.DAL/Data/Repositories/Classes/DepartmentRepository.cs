using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Data.Repositories.Interfaces;
using Project.DAL.Models;

namespace Project.DAL.Data.Repositories.Classes
{
    public class DepartmentRepository : IDepartmentRepository
    { 
        private readonly AppDbContext _dbcontext;

        public DepartmentRepository(AppDbContext dbContext) // Constructor Injection
        {
            _dbcontext = dbContext;
        }

        public int Add(Department entity)
        {
            _dbcontext.Add(entity);
            return _dbcontext.SaveChanges();

        }

        public int Delete(Department entity)
        {
            _dbcontext.Departments.Remove(entity);
            return _dbcontext.SaveChanges();

        }

        public IEnumerable<Department> GetAll(bool withtracking = false)
        {
            if (withtracking)
                return _dbcontext.Departments.ToList();
            return _dbcontext.Departments.AsNoTracking().ToList();
        }

        public Department GetById(int id)
        {
            return _dbcontext.Departments.Find(id);
        }

        public int Update(Department entity)
        {
            _dbcontext.Departments.Update(entity);
           return _dbcontext.SaveChanges(); // return number of rows affected
        }
    }
}
