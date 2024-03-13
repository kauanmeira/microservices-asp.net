using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 6L, "T-Shirt", "T-Shirt Star Wars, Size M, Color Black", "https://m.media-amazon.com/images/I/61pHbfgnBnL._AC_SX522_.jpg", "T-Shirt Star Wars", 69.9m },
                    { 7L, "T-Shirt", "T-Shirt Spongebob, Size L, Color Yellow", "https://img.elo7.com.br/product/685x685/3699E5B/camisa-camiseta-bob-esponja-infantil-estampa-total-bob2-inf-camisetas.jpg", "T-Shirt Spongebob", 69.9m },
                    { 8L, "Bottle", "Thermal bottle One Piece, Color Black", "https://http2.mlstatic.com/D_NQ_NP_625965-CBT70188422598_062023-O.webp", "Thermal bottle One Piece", 45m },
                    { 9L, "Bottle", "Thermal Naruto, Color Orange", "https://acdn.mitiendanube.com/stores/001/584/917/products/whatsapp-image-2023-04-19-at-12-11-45-pm1-62d7c1cfebcc70abd816819186133306-640-0.webp", "Thermal bottle Naruto", 45m },
                    { 10L, "Miniature Doll", "Naruto anime miniature doll, obito character", "https://images-americanas.b2w.io/produtos/71841396/imagens/funko-pop-anime-naruto-tobi/71841396_1_large.jpg", "Funko Naruto/Obito", 45m },
                    { 11L, "Miniature Doll", "Harry Potter miniature doll, harry character", "https://m.media-amazon.com/images/I/71grqjRENdL._AC_UF894,1000_QL80_.jpg", "Funko Harry Potter", 45m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "id",
                keyValue: 11L);
        }
    }
}
