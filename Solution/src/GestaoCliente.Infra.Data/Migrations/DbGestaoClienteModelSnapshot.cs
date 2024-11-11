﻿// <auto-generated />
using System;
using GestaoCliente.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoCliente.Infra.Data.Migrations
{
    [DbContext(typeof(DbGestaoCliente))]
    partial class DbGestaoClienteModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestaoCliente.Core.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("newid()")
                        .HasComment("Identificador único do cliente");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Email")
                        .HasComment("E-mail do cliente, campo único para cada cliente");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Nome")
                        .HasComment("Nome do cliente");

                    b.HasKey("Id")
                        .HasName("Pk_Clientes");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("UQ_Cliente_Email");

                    b.ToTable("Clientes", "dbo", t =>
                        {
                            t.HasComment("Armazenamento dos cliente");
                        });
                });

            modelBuilder.Entity("GestaoCliente.Core.Domain.Entities.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id")
                        .HasDefaultValueSql("newid()")
                        .HasComment("Chave da tabela endereço");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Apelido")
                        .HasComment("Apelido identificador via sistema do enderço");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ClienteId")
                        .HasComment("Chave da tabela Cliente");

                    b.Property<string>("Complemento")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Complemento")
                        .HasComment("Campo descritivo para detalhar o endereço");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("Logradouro")
                        .HasComment("Campo com o detalhe/nome do logradouro");

                    b.Property<int>("LogradouroId")
                        .HasColumnType("int")
                        .HasColumnName("LogradouroId")
                        .HasComment("Chave da tabela tipo logradouro");

                    b.Property<string>("Numero")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Numero")
                        .HasComment("Numero do endereço");

                    b.HasKey("Id")
                        .HasName("Pk_Enderecos");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("ClienteId");

                    b.HasIndex("LogradouroId");

                    b.ToTable("Enderecos", "dbo", t =>
                        {
                            t.HasComment("Tabela para armazenar os logradouros dos clientes");
                        });
                });

            modelBuilder.Entity("GestaoCliente.Core.Domain.Entities.TiposLogradouro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasComment("Chave da tabela tipo logradouro");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("Ativo")
                        .HasComment("Status do tipo logradouro");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome")
                        .HasComment("Nome identificador do tipo logradouro");

                    b.HasKey("Id")
                        .HasName("Pk_Logradouros");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.HasIndex("Nome")
                        .IsUnique()
                        .HasDatabaseName("UQ_Logradouros_Nome")
                        .HasFilter("[Nome] IS NOT NULL");

                    b.ToTable("TiposLogradouro", "dbo", t =>
                        {
                            t.HasComment("Tipos de logradouros para cadastro de endereço");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            Nome = "Rua"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            Nome = "Avenida"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            Nome = "Praça"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            Nome = "Alameda"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            Nome = "Travessa"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            Nome = "Estrada"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            Nome = "Rodovia"
                        },
                        new
                        {
                            Id = 8,
                            Ativo = true,
                            Nome = "Largo"
                        },
                        new
                        {
                            Id = 9,
                            Ativo = true,
                            Nome = "Vila"
                        },
                        new
                        {
                            Id = 10,
                            Ativo = true,
                            Nome = "Beco"
                        },
                        new
                        {
                            Id = 11,
                            Ativo = true,
                            Nome = "Quadra"
                        },
                        new
                        {
                            Id = 12,
                            Ativo = true,
                            Nome = "Servidão"
                        });
                });

            modelBuilder.Entity("GestaoCliente.Core.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("GestaoCliente.Core.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .IsRequired()
                        .HasConstraintName("Fk_Clientes_Enderecos");

                    b.HasOne("GestaoCliente.Core.Domain.Entities.TiposLogradouro", "TiposLogradouro")
                        .WithMany("Enderecos")
                        .HasForeignKey("LogradouroId")
                        .IsRequired()
                        .HasConstraintName("Fk_TiposLogradouro_Enderecos");

                    b.Navigation("Cliente");

                    b.Navigation("TiposLogradouro");
                });

            modelBuilder.Entity("GestaoCliente.Core.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("GestaoCliente.Core.Domain.Entities.TiposLogradouro", b =>
                {
                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
