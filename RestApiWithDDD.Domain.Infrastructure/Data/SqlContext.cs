﻿using Microsoft.EntityFrameworkCore;
using RestApiWithDDD.Domain;
using System;
using System.Linq;

public class SqlContext : DbContext
{
    public SqlContext() 
    { 

    }

    public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

    public DbSet<Client>? Clients { get; set; }

    public DbSet<Product>? Products { get; set; }

    public override int SaveChanges()
    {
        foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null ))
        {
            if (entry.State == EntityState.Added)
            {
                entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Property("RegistrationDate").IsModified = false;
            }
        }

        return base.SaveChanges();
    }
}
