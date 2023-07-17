﻿// <auto-generated />
using System;
using DidactEngine.Services.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DidactEngine.Migrations
{
    [DbContext(typeof(DidactDbContext))]
    [Migration("20230717051620_InitialSnapshot")]
    partial class InitialSnapshot
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DidactEngine.Models.Entities.FifoQueue", b =>
                {
                    b.Property<int>("FifoQueueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FifoQueueId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("FifoQueueId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("FifoQueue", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.FifoQueueInbound", b =>
                {
                    b.Property<long>("FifoQueueInboundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FifoQueueInboundId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("FifoQueueId")
                        .HasColumnType("int");

                    b.Property<long>("FlowId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("FifoQueueInboundId");

                    b.HasIndex("FifoQueueId");

                    b.HasIndex("FlowId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("FifoQueueInbound", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.Flow", b =>
                {
                    b.Property<long>("FlowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FlowId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("AssemblyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConcurrencyLimit")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullyQualifiedTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Version")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("FlowId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Flow", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.FlowSchedule", b =>
                {
                    b.Property<long>("FlowScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FlowScheduleId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CronExpression")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("FlowId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("LastRunTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("NextRunTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("ScheduleTypeId")
                        .HasColumnType("int");

                    b.HasKey("FlowScheduleId");

                    b.HasIndex("FlowId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("ScheduleTypeId");

                    b.ToTable("FlowSchedule", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organization", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.ScheduleType", b =>
                {
                    b.Property<int>("ScheduleTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleTypeId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("ScheduleTypeId");

                    b.ToTable("ScheduleType", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.StandardQueue", b =>
                {
                    b.Property<int>("StandardQueueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StandardQueueId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("StandardQueueId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("StandardQueue", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.StandardQueueInbound", b =>
                {
                    b.Property<long>("StandardQueueInboundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StandardQueueInboundId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("FlowId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("StandardQueueId")
                        .HasColumnType("int");

                    b.HasKey("StandardQueueInboundId");

                    b.HasIndex("FlowId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("StandardQueueId");

                    b.ToTable("StandardQueueInbound", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("StateId");

                    b.ToTable("State", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.TriggerType", b =>
                {
                    b.Property<int>("TriggerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TriggerTypeId"));

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("TriggerTypeId");

                    b.ToTable("TriggerType", (string)null);
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.FifoQueue", b =>
                {
                    b.HasOne("DidactEngine.Models.Entities.Organization", "Organization")
                        .WithMany("FifoQueues")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.FifoQueueInbound", b =>
                {
                    b.HasOne("DidactEngine.Models.Entities.FifoQueue", "FifoQueue")
                        .WithMany("FifoQueueInbounds")
                        .HasForeignKey("FifoQueueId")
                        .IsRequired()
                        .HasConstraintName("FK_FifoQueueInbound_FifoQueue");

                    b.HasOne("DidactEngine.Models.Entities.Flow", "Flow")
                        .WithMany("FifoQueueInbounds")
                        .HasForeignKey("FlowId")
                        .IsRequired()
                        .HasConstraintName("FK_FifoQueueInbound_Flow");

                    b.HasOne("DidactEngine.Models.Entities.Organization", "Organization")
                        .WithMany("FifoQueueInbounds")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_FifoQueueInbound_Organization");

                    b.Navigation("FifoQueue");

                    b.Navigation("Flow");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.Flow", b =>
                {
                    b.HasOne("DidactEngine.Models.Entities.Organization", "Organization")
                        .WithMany("Flows")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_Flow_Organization");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.FlowSchedule", b =>
                {
                    b.HasOne("DidactEngine.Models.Entities.Flow", "Flow")
                        .WithMany()
                        .HasForeignKey("FlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DidactEngine.Models.Entities.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DidactEngine.Models.Entities.ScheduleType", "ScheduleType")
                        .WithMany()
                        .HasForeignKey("ScheduleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flow");

                    b.Navigation("Organization");

                    b.Navigation("ScheduleType");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.StandardQueue", b =>
                {
                    b.HasOne("DidactEngine.Models.Entities.Organization", "Organization")
                        .WithMany("StandardQueues")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.StandardQueueInbound", b =>
                {
                    b.HasOne("DidactEngine.Models.Entities.Flow", "Flow")
                        .WithMany("StandardQueueInbounds")
                        .HasForeignKey("FlowId")
                        .IsRequired()
                        .HasConstraintName("FK_StandardQueueInbound_Flow");

                    b.HasOne("DidactEngine.Models.Entities.Organization", "Organization")
                        .WithMany("StandardQueueInbounds")
                        .HasForeignKey("OrganizationId")
                        .IsRequired()
                        .HasConstraintName("FK_StandardQueueInbound_Organization");

                    b.HasOne("DidactEngine.Models.Entities.StandardQueue", "StandardQueue")
                        .WithMany("StandardQueueInbounds")
                        .HasForeignKey("StandardQueueId")
                        .IsRequired()
                        .HasConstraintName("FK_StandardQueueInbound_StandardQueue");

                    b.Navigation("Flow");

                    b.Navigation("Organization");

                    b.Navigation("StandardQueue");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.FifoQueue", b =>
                {
                    b.Navigation("FifoQueueInbounds");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.Flow", b =>
                {
                    b.Navigation("FifoQueueInbounds");

                    b.Navigation("StandardQueueInbounds");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.Organization", b =>
                {
                    b.Navigation("FifoQueueInbounds");

                    b.Navigation("FifoQueues");

                    b.Navigation("Flows");

                    b.Navigation("StandardQueueInbounds");

                    b.Navigation("StandardQueues");
                });

            modelBuilder.Entity("DidactEngine.Models.Entities.StandardQueue", b =>
                {
                    b.Navigation("StandardQueueInbounds");
                });
#pragma warning restore 612, 618
        }
    }
}