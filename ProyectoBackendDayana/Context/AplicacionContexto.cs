﻿using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<pilotos> pilotos { get; set; }
        public DbSet<hangares> hangares { get; set; }
        public DbSet<aviones> Aviones { get; set; }


    }
}