using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Net5.Fundamentals.AspNet.Data.Repositories;
using Entities = Net5.Fundamentals.AspNet.Data.Entities;

namespace Net5.Fundamentals.AspNet.Client.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly CustomerRepository _customerRepository;
        public List<Entities.Customer> Customers { get; set; }
        public IndexModel(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void OnGet()
        {
            Customers = _customerRepository.List();
        }
    }
}
