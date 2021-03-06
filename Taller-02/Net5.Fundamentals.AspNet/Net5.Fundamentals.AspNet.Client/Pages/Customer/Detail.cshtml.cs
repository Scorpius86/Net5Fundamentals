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
    public class DetailModel : PageModel
    {
        private readonly CustomerRepository _customerRepository;
        public Entities.Customer Customer { get; set; }
        public DetailModel(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Customer = _customerRepository.Get(id.Value);

            if(Customer == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
