using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;
using Assignment3.Models;

namespace Assignment3.Controllers
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


        public EmployeeBase EmployeeEdit(EmployeeEdit employee) {

            var o = ds.Employees.Find(employee.EmployeeId);

            if (o == null)
            {

                return null;
            }
            else {

               ds.Entry(o).CurrentValues.SetValues(employee);
               ds.SaveChanges();
               return Mapper.Map<Employee, EmployeeBase>(o);
     

            }


        }


        public IEnumerable<TrackBase> TrackGetAll()
        {


            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(ds.Tracks);
        }

        public IEnumerable<TrackBase> TrackGetAllPop()
        {

            var o = ds.Tracks;

            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(ds.Tracks.Where(f => f.GenreId == 9).OrderBy(g => g.Name));
           
        }

             public IEnumerable<TrackBase> TrackGetAllDeepPurple()
        {
            var x = "Jon Lord";
            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(ds.Tracks.Where(f => f.Composer.Contains("Jon Lord")).OrderBy(g => g.TrackId));
        }


        public IEnumerable<TrackBase> TrackGetAllTop100Longest()
        {
            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(ds.Tracks.OrderByDescending(f => f.Milliseconds).Take(100));
        }



    }

        

        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:

    }

