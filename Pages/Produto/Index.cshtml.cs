using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cadastro.Models;

namespace Cadastro.Pages_Produto
{
    public class IndexModel : PageModel
    {
        private readonly Cadastro.Models.ClienteContext _context;

        public IndexModel(Cadastro.Models.ClienteContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
