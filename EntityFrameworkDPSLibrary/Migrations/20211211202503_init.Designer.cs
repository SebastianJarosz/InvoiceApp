// <auto-generated />
using System;
using EntityFrameworkDPSLibrary.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkDPSLibrary.Migrations
{
    [DbContext(typeof(MFSDbContext))]
    [Migration("20211211202503_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkDPSLibrary.Models.Buyer", b =>
                {
                    b.Property<string>("NIP")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("FlatNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIP");

                    b.ToTable("Buyer");
                });

            modelBuilder.Entity("EntityFrameworkDPSLibrary.Models.DailyInvoiceCounter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DailyInvoiceCounter");
                });

            modelBuilder.Entity("EntityFrameworkDPSLibrary.Models.Invoice", b =>
                {
                    b.Property<string>("InvoiceNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BuyerNIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModyficationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SellerNIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvoiceNumber");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("EntityFrameworkDPSLibrary.Models.Product", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("MeasureUnit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Code");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("EntityFrameworkDPSLibrary.Models.ProductsOnInvoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InvoiceNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("QuantityOfProduct")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("InvoiceNumber");

                    b.HasIndex("ProductCode");

                    b.ToTable("ProductsOnInvoice");
                });

            modelBuilder.Entity("EntityFrameworkDPSLibrary.Models.Seller", b =>
                {
                    b.Property<string>("NIP")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("FlatNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIP");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("EntityFrameworkDPSLibrary.Models.ProductsOnInvoice", b =>
                {
                    b.HasOne("EntityFrameworkDPSLibrary.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceNumber");

                    b.HasOne("EntityFrameworkDPSLibrary.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductCode");

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
