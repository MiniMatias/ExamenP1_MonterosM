using ExamenP1_MonterosM.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace ExamenP1_MonterosM.Data 
{
    public class MonterosMContext : DbContext
    {
        public MonterosMContext(DbContextOptions<MonterosMContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Reserva> Reservas { get; set; } = default!;
        public DbSet<PlanRecompensas> PlanesRecompensas
        { get; set; }
            = default!;
    }
}