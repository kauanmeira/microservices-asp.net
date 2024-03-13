using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "T-Shirt Star Wars",
                Price = new decimal(69.9),
                Description = "T-Shirt Star Wars, Size M, Color Black",
                ImageUrl = "https://m.media-amazon.com/images/I/61pHbfgnBnL._AC_SX522_.jpg",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "T-Shirt Spongebob",
                Price = new decimal(69.9),
                Description = "T-Shirt Spongebob, Size L, Color Yellow",
                ImageUrl = "https://img.elo7.com.br/product/685x685/3699E5B/camisa-camiseta-bob-esponja-infantil-estampa-total-bob2-inf-camisetas.jpg",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Thermal bottle One Piece",
                Price = new decimal(45),
                Description = "Thermal bottle One Piece, Color Black",
                ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_625965-CBT70188422598_062023-O.webp",
                CategoryName = "Bottle"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Thermal bottle Naruto",
                Price = new decimal(45),
                Description = "Thermal Naruto, Color Orange",
                ImageUrl= "https://acdn.mitiendanube.com/stores/001/584/917/products/whatsapp-image-2023-04-19-at-12-11-45-pm1-62d7c1cfebcc70abd816819186133306-640-0.webp",
                CategoryName = "Bottle"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Funko Naruto/Obito",
                Price = new decimal(45),
                Description = "Naruto anime miniature doll, obito character",
                ImageUrl = "https://images-americanas.b2w.io/produtos/71841396/imagens/funko-pop-anime-naruto-tobi/71841396_1_large.jpg",
                CategoryName = "Miniature Doll"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Funko Harry Potter",
                Price = new decimal(45),
                Description = "Harry Potter miniature doll, harry character",
                ImageUrl = "https://m.media-amazon.com/images/I/71grqjRENdL._AC_UF894,1000_QL80_.jpg",
                CategoryName = "Miniature Doll"
            });
        }
    }
}
