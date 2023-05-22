using Microsoft.EntityFrameworkCore;

namespace PracticalApps;
public class Northwind: DbContext
{
    public Northwind(DbContextOptions<Northwind> options)
        : base(options) { }
}
