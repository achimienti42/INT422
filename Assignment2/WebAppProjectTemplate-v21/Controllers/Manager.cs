using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;
using WebAppProjectTemplate_v21.Models;

namespace WebAppProjectTemplate_v21.Controllers
{
    public class Manager
    {
        // Reference to the data context
        private DataContext ds = new DataContext();

        public IEnumerable<EmployeeBase> EmployeeGetAll()
        {
            return Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeBase>>(ds.Employees);
        }

        public EmployeeBase EmployeeGetById(int id)
        {
            var o = ds.Employees.Find(id);
            return (o == null) ? null : Mapper.Map<Employee, EmployeeBase>(o);
        }

        public EmployeeBase EmployeeAdd(EmployeeAdd newItem)
        {
            var addedItem = ds.Employees.Add(Mapper.Map<EmployeeAdd, Employee>(newItem));
            ds.SaveChanges();
            return (addedItem == null) ? null : Mapper.Map<Employee, EmployeeBase>(addedItem);
        }

        public Manager()
        {
            // If necessary, add constructor code here
        }

        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:

    }
}
