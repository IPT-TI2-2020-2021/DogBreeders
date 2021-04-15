﻿// <auto-generated />
using System;
using DogBreeders.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogBreeders.Migrations
{
    [DbContext(typeof(DogBreedersDB))]
    [Migration("20210415133706_InitialStateOfDataBase")]
    partial class InitialStateOfDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DogBreeders.Models.Breeds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("DogBreeders.Models.DogBreeder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DogBreeders");
                });

            modelBuilder.Entity("DogBreeders.Models.DogBreederDogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DogBreederFK")
                        .HasColumnType("int");

                    b.Property<int>("DogFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DogBreederFK");

                    b.HasIndex("DogFK");

                    b.ToTable("DogBreedersDogs");
                });

            modelBuilder.Entity("DogBreeders.Models.Dogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BreedFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BreedFK");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("DogBreeders.Models.Photos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DogFK")
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DogFK");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("DogBreeders.Models.DogBreederDogs", b =>
                {
                    b.HasOne("DogBreeders.Models.DogBreeder", "DogBreeder")
                        .WithMany("Dogs")
                        .HasForeignKey("DogBreederFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogBreeders.Models.Dogs", "Dog")
                        .WithMany("DogBreeders")
                        .HasForeignKey("DogFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("DogBreeder");
                });

            modelBuilder.Entity("DogBreeders.Models.Dogs", b =>
                {
                    b.HasOne("DogBreeders.Models.Breeds", "Breed")
                        .WithMany("Dogs")
                        .HasForeignKey("BreedFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Breed");
                });

            modelBuilder.Entity("DogBreeders.Models.Photos", b =>
                {
                    b.HasOne("DogBreeders.Models.Dogs", "Dog")
                        .WithMany("Photos")
                        .HasForeignKey("DogFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("DogBreeders.Models.Breeds", b =>
                {
                    b.Navigation("Dogs");
                });

            modelBuilder.Entity("DogBreeders.Models.DogBreeder", b =>
                {
                    b.Navigation("Dogs");
                });

            modelBuilder.Entity("DogBreeders.Models.Dogs", b =>
                {
                    b.Navigation("DogBreeders");

                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
