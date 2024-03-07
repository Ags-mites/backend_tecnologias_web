using Backend.Entities;
using Backend.Persistence.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;

        }

        [HttpGet("all")]
        public async Task<ActionResult> GetAllAccounts()
        {
            var accounts =  await _accountRepository.GetAllAsync();
            return Ok(accounts);
        }

        [HttpPost]
        public async Task <IActionResult> Post(Account account)
        {
            var accountCreated = await _accountRepository.AddAsync(account);
            return Ok(account);
        }
    }
}