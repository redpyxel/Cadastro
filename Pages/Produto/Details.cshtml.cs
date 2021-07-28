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
    public class DetailsModel : PageModel
    {
        private readonly Cadastro.Models.ClienteContext _context;

        public DetailsModel(Cadastro.Models.ClienteContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto = await _context.Produto.FirstOrDefaultAsync(m => m.ProdutoID == id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
