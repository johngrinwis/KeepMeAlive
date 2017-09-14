using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using KeepMeAlive.Data;
using KeepMeAlive.Domain;

namespace KeepMeAlive.Data.Migrations
{
    [DbContext(typeof(KeepMeAliveDbContext))]
    [Migration("20170831151620_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KeepMeAlive.Domain.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("HouseLetter");

                    b.Property<int>("HouseNumber");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("KeepMeAlive.Domain.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Email");

                    b.Property<string>("Initials");

                    b.Property<int>("MobilePhone");

                    b.Property<string>("Name");

                    b.Property<int>("NotifyBy");

                    b.Property<string>("SurName");

                    b.Property<string>("SurNamePrefix");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("KeepMeAlive.Domain.KeepAliveUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Email");

                    b.Property<string>("Initials");

                    b.Property<int>("MobilePhone");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("SurName");

                    b.Property<string>("SurNamePrefix");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("KeepAliveUsers");
                });

            modelBuilder.Entity("KeepMeAlive.Domain.Contact", b =>
                {
                    b.HasOne("KeepMeAlive.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("KeepMeAlive.Domain.KeepAliveUser", b =>
                {
                    b.HasOne("KeepMeAlive.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });
        }
    }
}
