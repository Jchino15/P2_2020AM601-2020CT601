﻿using Microsoft.EntityFrameworkCore;
using P2_2020AM601_2020CT601.Models;

namespace P2_2020AM601_2020CT601.Models
{
    public class covidcontext : DbContext
    {
        public covidcontext(DbContextOptions options): base(options)
        { }
        public DbSet<P2_2020AM601_2020CT601.Models.Departamentos>? Departamentos { get; set; }
        public DbSet<P2_2020AM601_2020CT601.Models.Generos>? Generos { get; set; }
    }
}