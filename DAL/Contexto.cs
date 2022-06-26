using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Coins> Coins { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coins>().HasData
        (
            new Coins() 
            {
                MonedaId = 1,
                Descripcion = "BitCoin",
                Valor = 23000,
                ImageUrl = "https://cdn.icon-icons.com/icons2/317/PNG/512/bitcoin-icon_34487.png"
            }
        );

        modelBuilder.Entity<Coins>().HasData
        (
            new Coins() 
            {
                MonedaId = 2,
                Descripcion = "Ethereum",
                Valor = 1227.58,
                ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png"
            }
        );

        modelBuilder.Entity<Coins>().HasData
        (
            new Coins() 
            {
                MonedaId = 3,
                Descripcion = "DogeCoin",
                Valor = 0.068,
                ImageUrl = "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png"
            }
        );

    }
}