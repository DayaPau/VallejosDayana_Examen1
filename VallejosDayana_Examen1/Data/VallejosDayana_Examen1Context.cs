using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VallejosDayana_Examen1.Models;

namespace VallejosDayana_Examen1.Data
{
    public class VallejosDayana_Examen1Context : DbContext
    {
        public VallejosDayana_Examen1Context (DbContextOptions<VallejosDayana_Examen1Context> options)
            : base(options)
        {
        }

        public DbSet<VallejosDayana_Examen1.Models.DVallejos> DVallejos { get; set; } = default!;
        public DbSet<VallejosDayana_Examen1.Models.Celular> Celular { get; set; } = default!;
    }
}
