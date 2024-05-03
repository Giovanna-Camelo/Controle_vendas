using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vendas.Models;
using Controle_Vendas.Models;

namespace Vendas.Data
{
    public class VendasContext : DbContext
    {
        public VendasContext (DbContextOptions<VendasContext> options)
            : base(options)
        {
        }

        public DbSet<Vendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<Vendas.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<Vendas.Models.Venda> Venda { get; set; } = default!;
        public DbSet<Controle_Vendas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Controle_Vendas.Models.Nivel_De_Acesso> Nivel_De_Acesso { get; set; } = default!;
        public DbSet<Controle_Vendas.Models.Login> Login { get; set; } = default!;
    }
}
