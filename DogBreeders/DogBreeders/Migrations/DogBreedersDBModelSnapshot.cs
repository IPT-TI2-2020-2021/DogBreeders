﻿// <auto-generated />
using System;
using DogBreeders.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogBreeders.Migrations
{
    [DbContext(typeof(DogBreedersDB))]
    partial class DogBreedersDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Retriever do Labrador"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Serra da Estrela"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pastor Alemão"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dogue Alemão"
                        },
                        new
                        {
                            Id = 5,
                            Name = "S. Bernardo"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Rafeiro do Alentejo"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Golden Retriever"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Border Collie"
                        });
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
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("DogBreeders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Largo do Pelourinho",
                            CellPhone = "967197885",
                            Email = "Marisa.Freitas@iol.pt",
                            Name = "Marisa Vieira",
                            PostalCode = "2305 - 515 PAIALVO"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Praça Infante Dom Henrique",
                            CellPhone = "963737476",
                            Email = "Fátima.Machado@gmail.com",
                            Name = "Fátima Ribeiro",
                            PostalCode = "2300 - 551 TOMAR"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Bairro Pimenta",
                            CellPhone = "967517256",
                            Email = "Paula.Lopes@iol.pt",
                            Name = "Paula Silva",
                            PostalCode = "2300 - 324 TOMAR"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Zona Industrial",
                            CellPhone = "967212144",
                            Email = "Mariline.Martins@sapo.pt",
                            Name = "Mariline Marques",
                            PostalCode = "2305 - 127 ASSEICEIRA TMR"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Rua de Bacelos",
                            CellPhone = "962125638",
                            Email = "Marcos.Rocha@sapo.pt",
                            Name = "Marcos Rocha",
                            PostalCode = "2475 - 013 BENEDITA"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Rua João Pedro Costa",
                            CellPhone = "961493756",
                            Email = "Alexandre.Dias@hotmail.com",
                            Name = "Alexandre Vieira",
                            PostalCode = "7630 - 782 ZAMBUJEIRA DO MAR"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Praça Infante Dom Henrique",
                            CellPhone = "961937768",
                            Email = "Paula.Vieira@clix.pt",
                            Name = "Paula Soares",
                            PostalCode = "2300 - 551 TOMAR"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Rua Corredora do Mestre (Palhavã de Cima)",
                            CellPhone = "964106478",
                            Email = "Mariline.Ribeiro@iol.pt",
                            Name = "Mariline Santos",
                            PostalCode = "2300 - 390 TOMAR"
                        },
                        new
                        {
                            Id = 10,
                            Address = "Largo do Flecheiro",
                            CellPhone = "964685937",
                            Email = "Roberto.Vieira@sapo.pt",
                            Name = "Roberto Pinto",
                            PostalCode = "2300 - 635 TOMAR"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DogBreederFK = 1,
                            DogFK = 1
                        },
                        new
                        {
                            Id = 2,
                            DogBreederFK = 2,
                            DogFK = 2
                        },
                        new
                        {
                            Id = 3,
                            DogBreederFK = 4,
                            DogFK = 3
                        },
                        new
                        {
                            Id = 4,
                            DogBreederFK = 5,
                            DogFK = 4
                        },
                        new
                        {
                            Id = 5,
                            DogBreederFK = 6,
                            DogFK = 5
                        },
                        new
                        {
                            Id = 6,
                            DogBreederFK = 7,
                            DogFK = 6
                        },
                        new
                        {
                            Id = 7,
                            DogBreederFK = 8,
                            DogFK = 7
                        },
                        new
                        {
                            Id = 8,
                            DogBreederFK = 9,
                            DogFK = 8
                        },
                        new
                        {
                            Id = 9,
                            DogBreederFK = 10,
                            DogFK = 9
                        },
                        new
                        {
                            Id = 10,
                            DogBreederFK = 5,
                            DogFK = 10
                        },
                        new
                        {
                            Id = 11,
                            DogBreederFK = 8,
                            DogFK = 11
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BreedFK = 1,
                            DateOfBirth = new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aguia da Quinta do Conde",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 2,
                            BreedFK = 1,
                            DateOfBirth = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aileen da Quinta do Lordy",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 3,
                            BreedFK = 5,
                            DateOfBirth = new DateTime(2011, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aladim do Canto do Bairro Pimenta",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 4,
                            BreedFK = 5,
                            DateOfBirth = new DateTime(2008, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Albert do Canto do Bairro Pimenta",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 5,
                            BreedFK = 2,
                            DateOfBirth = new DateTime(2012, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alabaster da Casa do Sobreiral",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 6,
                            BreedFK = 6,
                            DateOfBirth = new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gannett do Quintal de Cima",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 7,
                            BreedFK = 3,
                            DateOfBirth = new DateTime(2010, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gardenia da Tapada de Cima",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 8,
                            BreedFK = 7,
                            DateOfBirth = new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Forte da Flecha do Indio",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 9,
                            BreedFK = 7,
                            DateOfBirth = new DateTime(2011, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Garbo da Flecha do Indio",
                            Sex = "M"
                        },
                        new
                        {
                            Id = 10,
                            BreedFK = 4,
                            DateOfBirth = new DateTime(2017, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Garfunkle da Quinta do Lordy",
                            Sex = "F"
                        },
                        new
                        {
                            Id = 11,
                            BreedFK = 8,
                            DateOfBirth = new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Garnet do Quintal de Cima",
                            Sex = "M"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 1,
                            Local = "",
                            NameOfPhoto = "Retriever_do_labrador.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 1,
                            Local = "",
                            NameOfPhoto = "Retriever_do_labrador_2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 2,
                            Local = "",
                            NameOfPhoto = "Retriever_do_labrador_3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 3,
                            Local = "",
                            NameOfPhoto = "s.bernardo.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 4,
                            Local = "casa",
                            NameOfPhoto = "s.bernardo_2.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 5,
                            Local = "",
                            NameOfPhoto = "serra_da_estrela.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 5,
                            Local = "",
                            NameOfPhoto = "serra_da_estrela_2.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 6,
                            Local = "Quinta",
                            NameOfPhoto = "Rafeiro_do_Alentejo.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 7,
                            Local = "",
                            NameOfPhoto = "pastor_alemao_2.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 7,
                            Local = "",
                            NameOfPhoto = "pastor_alemao.jpg"
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 8,
                            Local = "",
                            NameOfPhoto = "golden-retriever_2.jpg"
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 8,
                            Local = "ninhada",
                            NameOfPhoto = "golden-retriever.jpg"
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 9,
                            Local = "",
                            NameOfPhoto = "Golden-Retriever-1.jpg"
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 10,
                            Local = "Casa da tia Ana",
                            NameOfPhoto = "Dogue_Alemao.jpg"
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DogFK = 11,
                            Local = "quintal",
                            NameOfPhoto = "border_collie.jpg"
                        });
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
