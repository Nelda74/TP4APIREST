﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TP4APIREST.Models.EntityFramework;

#nullable disable

namespace TP4APIREST.Migrations
{
    [DbContext(typeof(FilmRatingsDBContext))]
    [Migration("20230223092246_CreationBDFilmRatings")]
    partial class CreationBDFilmRatings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TP4APIREST.Models.EntityFramework.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("flm_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FilmId"));

                    b.Property<DateTime?>("DateSortie")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("flm_datesortie");

                    b.Property<decimal?>("Duree")
                        .HasColumnType("numeric")
                        .HasColumnName("flm_duree");

                    b.Property<string>("Genre")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("flm_genre");

                    b.Property<string>("Resume")
                        .HasColumnType("text")
                        .HasColumnName("flm_resume");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("flm_titre");

                    b.HasKey("FilmId");

                    b.ToTable("t_e_film_flm");
                });

            modelBuilder.Entity("TP4APIREST.Models.EntityFramework.Notation", b =>
                {
                    b.Property<int>("UtilisateurId")
                        .HasColumnType("integer")
                        .HasColumnName("utl_id")
                        .HasColumnOrder(0);

                    b.Property<int>("FilmId")
                        .HasColumnType("integer")
                        .HasColumnName("flm_id")
                        .HasColumnOrder(1);

                    b.Property<int?>("Note")
                        .HasColumnType("integer")
                        .HasColumnName("not_note");

                    b.HasKey("UtilisateurId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("t_j_notation_not");
                });

            modelBuilder.Entity("TP4APIREST.Models.EntityFramework.Utilisateur", b =>
                {
                    b.Property<int>("UtilisateurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("utl_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UtilisateurId"));

                    b.Property<string>("CodePostal")
                        .HasColumnType("char(5)")
                        .HasColumnName("utl_cp");

                    b.Property<DateTime?>("DateCreation")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("utl_datecreation");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double precision")
                        .HasColumnName("utl_latitude");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double precision")
                        .HasColumnName("utl_longitude");

                    b.Property<string>("Mail")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("utl_mail");

                    b.Property<string>("Mobile")
                        .HasColumnType("char(10)")
                        .HasColumnName("utl_mobile");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("utl_nom");

                    b.Property<string>("Pays")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("utl_pays");

                    b.Property<string>("Prenom")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("utl_prenom");

                    b.Property<string>("Pwd")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("utl_pwd");

                    b.Property<string>("Rue")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("utl_rue");

                    b.Property<string>("Ville")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("utl_ville");

                    b.HasKey("UtilisateurId");

                    b.ToTable("t_e_utilisateur_utl");
                });

            modelBuilder.Entity("TP4APIREST.Models.EntityFramework.Notation", b =>
                {
                    b.HasOne("TP4APIREST.Models.EntityFramework.Film", "FilmNavigation")
                        .WithMany("Notations")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP4APIREST.Models.EntityFramework.Utilisateur", "UtilisateurNavigation")
                        .WithMany("NotesUtilisateur")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilmNavigation");

                    b.Navigation("UtilisateurNavigation");
                });

            modelBuilder.Entity("TP4APIREST.Models.EntityFramework.Film", b =>
                {
                    b.Navigation("Notations");
                });

            modelBuilder.Entity("TP4APIREST.Models.EntityFramework.Utilisateur", b =>
                {
                    b.Navigation("NotesUtilisateur");
                });
#pragma warning restore 612, 618
        }
    }
}
