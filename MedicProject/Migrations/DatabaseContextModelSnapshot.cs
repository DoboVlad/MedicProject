﻿// <auto-generated />
using System;
using MedicProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicProject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MedicProject.Models.Appointments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime");

                    b.Property<string>("endHour")
                        .HasColumnType("text");

                    b.Property<string>("hour")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("APPOINTMENTS");
                });

            modelBuilder.Entity("MedicProject.Models.Hour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Availability")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("endHour")
                        .HasColumnType("text");

                    b.Property<string>("startHour")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("hours");
                });

            modelBuilder.Entity("MedicProject.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("datetime");

                    b.Property<string>("ReceiverEmail")
                        .HasColumnType("text");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<string>("TransmitterEmail")
                        .HasColumnType("text");

                    b.Property<int>("TransmitterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("TransmitterId");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("MedicProject.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("day")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("schedules");
                });

            modelBuilder.Entity("MedicProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(4000)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(4000)");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<string>("cnp")
                        .HasColumnType("text");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<int?>("doctorId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .HasColumnType("text");

                    b.Property<int>("isApproved")
                        .HasColumnType("int");

                    b.Property<int>("isMedic")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("photo")
                        .HasColumnType("text");

                    b.Property<int>("validated")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("MedicProject.Models.Appointments", b =>
                {
                    b.HasOne("MedicProject.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MedicProject.Models.Hour", b =>
                {
                    b.HasOne("MedicProject.Models.Schedule", "schedule")
                        .WithMany("Hour")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MedicProject.Models.Message", b =>
                {
                    b.HasOne("MedicProject.Models.User", "Receiver")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MedicProject.Models.User", "Transmitter")
                        .WithMany("MessagesSent")
                        .HasForeignKey("TransmitterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MedicProject.Models.Schedule", b =>
                {
                    b.HasOne("MedicProject.Models.User", "user")
                        .WithMany("schedule")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MedicProject.Models.User", b =>
                {
                    b.HasOne("MedicProject.Models.User", "doctor")
                        .WithMany("Pacients")
                        .HasForeignKey("doctorId");
                });
#pragma warning restore 612, 618
        }
    }
}
