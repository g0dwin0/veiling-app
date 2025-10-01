using Microsoft.EntityFrameworkCore;

public class VeilingAPIContext : DbContext
{
    public VeilingAPIContext(DbContextOptions<VeilingAPIContext> options) : base(options)
    {
        
    }
}