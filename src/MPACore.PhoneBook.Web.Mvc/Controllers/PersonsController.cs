using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using MPACore.PhoneBook.Authorization;
using MPACore.PhoneBook.Controllers;
using MPACore.PhoneBook.PhoneBooks;
using MPACore.PhoneBook.PhoneBooks.Dtos;

namespace MPACore.PhoneBook.Web.Mvc.Controllers
{
    public class PersonsController : PhoneBookControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }
        public async System.Threading.Tasks.Task<IActionResult> Index(GetPersonInput input)
        {
            input.SkipCount = 0;
            input.MaxResultCount = 500;
            var dtos = await _personAppService.GetPagedPersonAsync(input);
            return View(dtos);
        }
        
    }
}