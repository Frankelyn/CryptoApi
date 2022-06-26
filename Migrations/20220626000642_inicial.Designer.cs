﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220626000642_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Coins", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            MonedaId = 1,
                            Descripcion = "BitCoin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/317/PNG/512/bitcoin-icon_34487.png",
                            Valor = 23000.0
                        },
                        new
                        {
                            MonedaId = 2,
                            Descripcion = "Ethereum",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png",
                            Valor = 1227.5799999999999
                        },
                        new
                        {
                            MonedaId = 3,
                            Descripcion = "DogeCoin",
                            ImageUrl = "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png",
                            Valor = 0.068000000000000005
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
