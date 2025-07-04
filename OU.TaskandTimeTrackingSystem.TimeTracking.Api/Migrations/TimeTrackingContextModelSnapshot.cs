﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OU.TaskandTimeTrackingSystem.TimeTracking.Api.DataAccess.Context;

#nullable disable

namespace OU.TaskandTimeTrackingSystem.TimeTracking.Api.Migrations
{
    [DbContext(typeof(TimeTrackingContext))]
    partial class TimeTrackingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.BreakPeriod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(16)
                        .HasColumnType("uuid");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("interval");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TimeEntryId")
                        .HasMaxLength(16)
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TimeEntryId");

                    b.ToTable("BreakPeriods");
                });

            modelBuilder.Entity("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Reminder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsSent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("ReminderTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TimeEntryId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TimeEntryId")
                        .IsUnique();

                    b.ToTable("Reminders", (string)null);
                });

            modelBuilder.Entity("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.TimeEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("interval");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Note")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TaskId")
                        .HasMaxLength(16)
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasMaxLength(16)
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("TimeEntries");
                });

            modelBuilder.Entity("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.BreakPeriod.BreakPeriod", b =>
                {
                    b.HasOne("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.TimeEntry", "TimeEntry")
                        .WithMany("BreakPeriods")
                        .HasForeignKey("TimeEntryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimeEntry");
                });

            modelBuilder.Entity("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Reminder", b =>
                {
                    b.HasOne("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.TimeEntry", "TimeEntry")
                        .WithOne()
                        .HasForeignKey("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.Reminders.Reminder", "TimeEntryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TimeEntry");
                });

            modelBuilder.Entity("OU.TaskandTimeTrackingSystem.TimeTracking.Api.Features.TimeEntry.TimeEntry", b =>
                {
                    b.Navigation("BreakPeriods");
                });
#pragma warning restore 612, 618
        }
    }
}
