using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data;

public class DataContext : DbContext
{

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<TransportTemplate> TransportTemplate { get; set; }

    public DbSet<Transport> Transport { get; set; }

    







}
