using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DogBreeders.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Retriever do Labrador" },
                    { 2, "Serra da Estrela" },
                    { 3, "Pastor Alemão" },
                    { 4, "Dogue Alemão" },
                    { 5, "S. Bernardo" },
                    { 6, "Rafeiro do Alentejo" },
                    { 7, "Golden Retriever" },
                    { 8, "Border Collie" }
                });

            migrationBuilder.InsertData(
                table: "DogBreeders",
                columns: new[] { "Id", "Address", "CellPhone", "Email", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 8, "Praça Infante Dom Henrique", "961937768", "Paula.Vieira@clix.pt", "Paula Soares", "2300 - 551 TOMAR" },
                    { 7, "Rua João Pedro Costa", "961493756", "Alexandre.Dias@hotmail.com", "Alexandre Vieira", "7630 - 782 ZAMBUJEIRA DO MAR" },
                    { 6, "Rua de Bacelos", "962125638", "Marcos.Rocha@sapo.pt", "Marcos Rocha", "2475 - 013 BENEDITA" },
                    { 1, "Largo do Pelourinho", "967197885", "Marisa.Freitas@iol.pt", "Marisa Vieira", "2305 - 515 PAIALVO" },
                    { 4, "Bairro Pimenta", "967517256", "Paula.Lopes@iol.pt", "Paula Silva", "2300 - 324 TOMAR" },
                    { 2, "Praça Infante Dom Henrique", "963737476", "Fátima.Machado@gmail.com", "Fátima Ribeiro", "2300 - 551 TOMAR" },
                    { 9, "Rua Corredora do Mestre (Palhavã de Cima)", "964106478", "Mariline.Ribeiro@iol.pt", "Mariline Santos", "2300 - 390 TOMAR" },
                    { 5, "Zona Industrial", "967212144", "Mariline.Martins@sapo.pt", "Mariline Marques", "2305 - 127 ASSEICEIRA TMR" },
                    { 10, "Largo do Flecheiro", "964685937", "Roberto.Vieira@sapo.pt", "Roberto Pinto", "2300 - 635 TOMAR" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "BreedFK", "DateOfBirth", "Name", "Sex" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aguia da Quinta do Conde", "F" },
                    { 2, 1, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aileen da Quinta do Lordy", "F" },
                    { 5, 2, new DateTime(2012, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alabaster da Casa do Sobreiral", "F" },
                    { 7, 3, new DateTime(2010, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gardenia da Tapada de Cima", "F" },
                    { 10, 4, new DateTime(2017, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garfunkle da Quinta do Lordy", "F" },
                    { 3, 5, new DateTime(2011, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aladim do Canto do Bairro Pimenta", "F" },
                    { 4, 5, new DateTime(2008, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert do Canto do Bairro Pimenta", "F" },
                    { 6, 6, new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gannett do Quintal de Cima", "F" },
                    { 8, 7, new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forte da Flecha do Indio", "F" },
                    { 9, 7, new DateTime(2011, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garbo da Flecha do Indio", "M" },
                    { 11, 8, new DateTime(2018, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garnet do Quintal de Cima", "M" }
                });

            migrationBuilder.InsertData(
                table: "DogBreedersDogs",
                columns: new[] { "Id", "DogBreederFK", "DogFK" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 9, 10, 9 },
                    { 2, 2, 2 },
                    { 5, 6, 5 },
                    { 8, 9, 8 },
                    { 7, 8, 7 },
                    { 6, 7, 6 },
                    { 10, 5, 10 },
                    { 11, 8, 11 },
                    { 3, 4, 3 },
                    { 4, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Date", "DogFK", "Local", "NameOfPhoto" },
                values: new object[,]
                {
                    { 13, new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "", "Golden-Retriever-1.jpg" },
                    { 12, new DateTime(2017, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "ninhada", "golden-retriever.jpg" },
                    { 11, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "", "golden-retriever_2.jpg" },
                    { 8, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Quinta", "Rafeiro_do_Alentejo.jpg" },
                    { 5, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "casa", "s.bernardo_2.jpg" },
                    { 14, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Casa da tia Ana", "Dogue_Alemao.jpg" },
                    { 10, new DateTime(2020, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "", "pastor_alemao.jpg" },
                    { 9, new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "", "pastor_alemao_2.jpg" },
                    { 7, new DateTime(2012, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "", "serra_da_estrela_2.jpg" },
                    { 6, new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "", "serra_da_estrela.jpg" },
                    { 3, new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", "Retriever_do_labrador_3.jpg" },
                    { 2, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", "Retriever_do_labrador_2.jpg" },
                    { 1, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", "Retriever_do_labrador.jpg" },
                    { 4, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "", "s.bernardo.jpg" },
                    { 15, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "quintal", "border_collie.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DogBreedersDogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DogBreeders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
