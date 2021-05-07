﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResultManagementSystem.Data;

namespace ResultManagementSystem.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("ResultManagementSystem.Models.Classes", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Class")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            Class = "Nursery",
                            StudentId = 1
                        },
                        new
                        {
                            ClassId = 2,
                            Class = "Nursery",
                            StudentId = 2
                        },
                        new
                        {
                            ClassId = 3,
                            Class = "Nursery",
                            StudentId = 3
                        },
                        new
                        {
                            ClassId = 4,
                            Class = "Nursery",
                            StudentId = 4
                        },
                        new
                        {
                            ClassId = 5,
                            Class = "Nursery",
                            StudentId = 5
                        },
                        new
                        {
                            ClassId = 6,
                            Class = "Nursery",
                            StudentId = 6
                        },
                        new
                        {
                            ClassId = 7,
                            Class = "LKG",
                            StudentId = 7
                        },
                        new
                        {
                            ClassId = 8,
                            Class = "LKG",
                            StudentId = 8
                        },
                        new
                        {
                            ClassId = 9,
                            Class = "LKG",
                            StudentId = 9
                        },
                        new
                        {
                            ClassId = 10,
                            Class = "LKG",
                            StudentId = 10
                        },
                        new
                        {
                            ClassId = 11,
                            Class = "LKG",
                            StudentId = 11
                        },
                        new
                        {
                            ClassId = 12,
                            Class = "LKG",
                            StudentId = 12
                        },
                        new
                        {
                            ClassId = 13,
                            Class = "LKG",
                            StudentId = 13
                        },
                        new
                        {
                            ClassId = 14,
                            Class = "UKG",
                            StudentId = 14
                        },
                        new
                        {
                            ClassId = 15,
                            Class = "UKG",
                            StudentId = 15
                        },
                        new
                        {
                            ClassId = 16,
                            Class = "UKG",
                            StudentId = 16
                        },
                        new
                        {
                            ClassId = 17,
                            Class = "UKG",
                            StudentId = 17
                        },
                        new
                        {
                            ClassId = 18,
                            Class = "UKG",
                            StudentId = 18
                        },
                        new
                        {
                            ClassId = 19,
                            Class = "UKG",
                            StudentId = 19
                        },
                        new
                        {
                            ClassId = 20,
                            Class = "UKG",
                            StudentId = 20
                        },
                        new
                        {
                            ClassId = 21,
                            Class = "UKG",
                            StudentId = 21
                        });
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClassesClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Credits")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject4")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId");

                    b.HasIndex("ClassesClassId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ResultId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ParentName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Name = "Bijay Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 2,
                            Name = "Sunil Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 3,
                            Name = "Ajay Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 4,
                            Name = "Mohan Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 5,
                            Name = "Sanu Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 6,
                            Name = "Sabch Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 7,
                            Name = "Neha Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 8,
                            Name = "Suhant Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 9,
                            Name = "Dev Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 10,
                            Name = "Krsishana Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 11,
                            Name = "krish Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 12,
                            Name = "Deb Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 13,
                            Name = "Avbch Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 14,
                            Name = "Mehana Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 15,
                            Name = "Shub Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 16,
                            Name = "Arohi Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 17,
                            Name = "Abc Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 18,
                            Name = "Sunhm Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 19,
                            Name = "suman Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 20,
                            Name = "Saroj Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        },
                        new
                        {
                            StudentId = 21,
                            Name = "Krishna Mandal",
                            ParentEmail = "mbijay833@gmail.com",
                            ParentName = "Bibek Mandal"
                        });
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Classes", b =>
                {
                    b.HasOne("ResultManagementSystem.Models.Student", "Student")
                        .WithMany("Classes")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Course", b =>
                {
                    b.HasOne("ResultManagementSystem.Models.Classes", "Classes")
                        .WithMany("Courses")
                        .HasForeignKey("ClassesClassId");

                    b.Navigation("Classes");
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Result", b =>
                {
                    b.HasOne("ResultManagementSystem.Models.Course", "Course")
                        .WithMany("Results")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResultManagementSystem.Models.Student", "Student")
                        .WithMany("Results")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Classes", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Course", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("ResultManagementSystem.Models.Student", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
