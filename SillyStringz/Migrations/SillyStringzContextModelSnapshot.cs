﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SillyStringz.Models;

namespace SillyStringz.Migrations
{
    [DbContext(typeof(SillyStringzContext))]
    partial class SillyStringzContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SillyStringz.Models.Engineer", b =>
                {
                    b.Property<int>("EngineerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EngineerDetails")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EngineerName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EngineerId");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("SillyStringz.Models.EngineerMachine", b =>
                {
                    b.Property<int>("EngineerMachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EngineerId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.HasKey("EngineerMachineId");

                    b.HasIndex("EngineerId");

                    b.HasIndex("MachineId");

                    b.ToTable("EngineerMachine");
                });

            modelBuilder.Entity("SillyStringz.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MachineDetails")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MachineId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("SillyStringz.Models.EngineerMachine", b =>
                {
                    b.HasOne("SillyStringz.Models.Engineer", "Engineer")
                        .WithMany("JoinEntities")
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SillyStringz.Models.Machine", "Machine")
                        .WithMany("JoinEntities")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("SillyStringz.Models.Engineer", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("SillyStringz.Models.Machine", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
