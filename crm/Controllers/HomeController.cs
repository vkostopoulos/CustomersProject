using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BOL;
using DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace crm.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public HomeController(IMapper mapper, IRepository<Customer> customerRepository)
        {
            _mapper             = mapper;
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Customer> Customers        = await _customerRepository.GetAllAsync();
            IEnumerable<CustomerDto> customersDto  = _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(Customers);
            return View(customersDto);
        }
    }
}