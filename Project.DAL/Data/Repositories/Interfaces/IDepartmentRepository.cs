using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Models;

namespace Project.DAL.Data.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        int Update(Department entity); // return type is intger for how many rows affected
        int Delete(Department entity);
        int Add(Department entity);


    }
}
