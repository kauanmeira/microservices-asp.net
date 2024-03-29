﻿// <auto-generated />
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20240313234800_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeekShopping.ProductAPI.Model.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 6L,
                            CategoryName = "T-Shirt",
                            Description = "T-Shirt Star Wars, Size M, Color Black",
                            ImageUrl = "https://m.media-amazon.com/images/I/61pHbfgnBnL._AC_SX522_.jpg",
                            Name = "T-Shirt Star Wars",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "T-Shirt",
                            Description = "T-Shirt Spongebob, Size L, Color Yellow",
                            ImageUrl = "https://img.elo7.com.br/product/685x685/3699E5B/camisa-camiseta-bob-esponja-infantil-estampa-total-bob2-inf-camisetas.jpg",
                            Name = "T-Shirt Spongebob",
                            Price = 69.9m
                        },
                        new
                        {
                            Id = 8L,
                            CategoryName = "Bottle",
                            Description = "Thermal bottle One Piece, Color Black",
                            ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_625965-CBT70188422598_062023-O.webp",
                            Name = "Thermal bottle One Piece",
                            Price = 45m
                        },
                        new
                        {
                            Id = 9L,
                            CategoryName = "Bottle",
                            Description = "Thermal Naruto, Color Orange",
                            ImageUrl = "https://acdn.mitiendanube.com/stores/001/584/917/products/whatsapp-image-2023-04-19-at-12-11-45-pm1-62d7c1cfebcc70abd816819186133306-640-0.webp",
                            Name = "Thermal bottle Naruto",
                            Price = 45m
                        },
                        new
                        {
                            Id = 10L,
                            CategoryName = "Miniature Doll",
                            Description = "Naruto anime miniature doll, obito character",
                            ImageUrl = "https://images-americanas.b2w.io/produtos/71841396/imagens/funko-pop-anime-naruto-tobi/71841396_1_large.jpg",
                            Name = "Funko Naruto/Obito",
                            Price = 45m
                        },
                        new
                        {
                            Id = 11L,
                            CategoryName = "Miniature Doll",
                            Description = "Harry Potter miniature doll, harry character",
                            ImageUrl = "https://m.media-amazon.com/images/I/71grqjRENdL._AC_UF894,1000_QL80_.jpg",
                            Name = "Funko Harry Potter",
                            Price = 45m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
