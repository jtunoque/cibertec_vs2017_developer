using Chinook.EF.CodeFirstData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.EF.CodeFirstData.DataAccess
{
    public class CustomerDA
    {
        private ChinookModel _context;

        public CustomerDA()
        {
            _context = new ChinookModel();
        }

        /// <summary>
        /// Obtiene la cantidad de registros
        /// </summary>
        /// <returns>Retorna un número entero</returns>
        public int Count()
        {
            //Utilizando Linq para obtener la 
            //cantidad de registros
            return _context.Customer.Count();
        }

        /// <summary>
        /// Permite obtener los datos de un Customera
        /// </summary>
        /// <param name="id">Parámetro de tipo entero que representa el código del Customera</param>
        /// <returns>Retorna toda la información del Customera</returns>
        public Customer GetCustomerById(int id)
        {
            return _context.Customer.Find(id);
        }

        /// <summary>
        /// Obtiene el listado de Customeras filtrado por nombre
        /// </summary>
        /// <param name="filtroByName">Filtro por nombre</param>
        /// <returns>Retorna lista de Customeras</returns>
        public IEnumerable<Customer> GetCustomers(string filtroByName)
        {
            return _context.Customer
                .Where(item => item.FirstName.Contains(filtroByName)
                               || item.LastName.Contains(filtroByName)).ToList();
        }

        public int InsertCustomer(Customer Customer)
        {
            _context.Customer.Add(Customer);
            _context.SaveChanges();

            return Customer.CustomerId;
        }

        public bool UpdateCustomer(Customer Customer)
        {
            _context.Customer.Attach(Customer);
            _context.Entry(Customer).State
                    = System.Data.Entity.EntityState.Modified;

            return _context.SaveChanges() > 0;
        }

        public bool DeleteCustomer(Customer Customer)
        {
            _context.Customer.Attach(Customer);
            _context.Customer.Remove(Customer);

            return _context.SaveChanges() > 0;
        }

        public bool UpdateContactos(Customer customer)
        {            
            //Obteniendo la información del customer
            var customerFound = _context.Customer.Find(customer.CustomerId);
            customerFound.Phone = customer.Phone;
            customerFound.Email = customer.Email;

            return _context.SaveChanges() > 0;
        }

        public bool UpdateContactos2(Customer customer)
        {
            _context.Configuration.ValidateOnSaveEnabled = false;
            //Obteniendo la información del customer
            _context.Customer.Attach(customer);            
            //Se esta actualizando el campo phone
            _context.Entry(customer).Property(
                item => item.Phone
                ).IsModified = true;
            //Se esta actualizando el campo email
            _context.Entry(customer).Property(
                item => item.Email
                ).IsModified = true;

            return _context.SaveChanges() > 0;
        }

    }
}
