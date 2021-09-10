using AutoMapper;
using AutomapperNetCore.Models;
using AutomapperNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperNetCore.Controllers
{

    [Route("user")]
    public class UserController : Controller
    {
        private readonly IMapper mapper;

        public UserController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Index()
        {
            var user = GetUserDetails();
            UserViewModel userViewModel = mapper.Map<UserViewModel>(user);
            return View(userViewModel);
        }



        public User GetUserDetails()
        {
            return new User { Address = "address", Email = "at@gm.com", FirstName = "Athula", Id = 1, LastName = "Chanx" };
        }
    }
}
