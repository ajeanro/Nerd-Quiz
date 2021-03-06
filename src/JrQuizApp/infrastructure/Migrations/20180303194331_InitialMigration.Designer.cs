﻿// <auto-generated />
using infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace infrastructure.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20180303194331_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entities.Quiz", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CorrectAnswer");

                    b.Property<bool>("IsComplete");

                    b.Property<string>("Option1");

                    b.Property<string>("Option2");

                    b.Property<string>("Option3");

                    b.Property<string>("Option4");

                    b.Property<string>("question");

                    b.HasKey("id");

                    b.ToTable("Quizzes");
                });
#pragma warning restore 612, 618
        }
    }
}
