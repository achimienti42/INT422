using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class Manager
    {
        // Reference to the data context
        private DataContext ds = new DataContext();

        public Manager()
        {
            // If necessary, add constructor code here
        }

        public IEnumerable<InvoiceBase> InvoiceGetAll()
        {
            return Mapper.Map<IEnumerable<Invoice>, IEnumerable<InvoiceBase>>(ds.Invoices);
        }

        public InvoiceBase InvoiceGetById(int id)
        {
            var o = ds.Invoices.Find(id);
            return (o == null) ? null : Mapper.Map<Invoice, InvoiceBase>(o);
        }


        public InvoiceWithDetail InvoiceGetByIdWithDetail(int id){

            var o = ds.Invoices.Find(id);

            ds.Invoices.Include("InvoiceLines.Track.MediaType").Include("Customer.Employee").Include("InvoiceLines.Track.Album.Artist").SingleOrDefault(t => t.InvoiceId == id);

            return (o == null) ? null : Mapper.Map<Invoice, InvoiceWithDetail>(o);
            
            
            }
        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:
        // ProductGetAll()
        // ProductGetById()
        // ProductAdd()
        // ProductEdit()
        // ProductDelete()
    }
}