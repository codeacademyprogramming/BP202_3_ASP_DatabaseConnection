using Eterna.DAL;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel
            {
                Portfolios = _context.Portfolios.Include(x=>x.Category).ToList(),
                Categories = _context.Categories.ToList()
            };

            return View(portfolioVM);
        }
    }
}
