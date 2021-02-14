﻿// <auto-generated />
using System;
using MgpTechTickets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MgpTechTickets.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MgpTechTickets.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Ambiente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ambientes");
                });

            modelBuilder.Entity("MgpTechTickets.Models.CanaisComunicacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Canais");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Chamado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFechamento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FilialId")
                        .HasColumnType("int");

                    b.Property<string>("Protocolo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SetorId")
                        .HasColumnType("int");

                    b.Property<string>("Status_")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserFinishId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserRedirectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.HasIndex("FilialId");

                    b.HasIndex("SetorId");

                    b.HasIndex("UserFinishId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserRedirectId");

                    b.ToTable("Chamados");
                });

            modelBuilder.Entity("MgpTechTickets.Models.ChamadoLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("ChamadoFilhoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlterado")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Solucao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ChamadoFilhoId");

                    b.HasIndex("UserId");

                    b.ToTable("ChamadoLogs");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("CliNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Filial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("FilCnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilNomefant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilRazsoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("MgpTechTickets.Models.FilialDados", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CpfRepre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailFinan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FilialId")
                        .HasColumnType("int");

                    b.Property<string>("IdentiRepre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFinan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeRepre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeleFinan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilialId");

                    b.ToTable("FilialDados");
                });

            modelBuilder.Entity("MgpTechTickets.Models.FilialEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FilialId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilialId");

                    b.ToTable("FilialEnderecos");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Pendencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<int?>("CanalId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("ChamadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFechamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PendenciaImagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Solucao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubCategoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("UserFinishId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.HasIndex("CanalId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ChamadoId");

                    b.HasIndex("SubCategoriaId");

                    b.HasIndex("UserFinishId");

                    b.HasIndex("UserId");

                    b.ToTable("Pendencias");
                });

            modelBuilder.Entity("MgpTechTickets.Models.PendenciaImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ChamadoFilhoId")
                        .HasColumnType("int");

                    b.Property<string>("PathName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.HasIndex("ChamadoFilhoId");

                    b.ToTable("PendenciaImages");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Procedimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Procedimentos");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Setores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tempo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoMedio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoRapido")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("MgpTechTickets.Models.SubCategorias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AmbienteId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("SubCategorias");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Agenda", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.CanaisComunicacao", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Categoria", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Chamado", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.HasOne("MgpTechTickets.Models.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FilialId");

                    b.HasOne("MgpTechTickets.Models.Setores", "Setor")
                        .WithMany()
                        .HasForeignKey("SetorId");

                    b.HasOne("MgpTechTickets.Models.Users", "UserFinish")
                        .WithMany()
                        .HasForeignKey("UserFinishId");

                    b.HasOne("MgpTechTickets.Models.Users", "User")
                        .WithMany("Chamados")
                        .HasForeignKey("UserId");

                    b.HasOne("MgpTechTickets.Models.Users", "UserRedirect")
                        .WithMany()
                        .HasForeignKey("UserRedirectId");

                    b.Navigation("Ambiente");

                    b.Navigation("Filial");

                    b.Navigation("Setor");

                    b.Navigation("User");

                    b.Navigation("UserFinish");

                    b.Navigation("UserRedirect");
                });

            modelBuilder.Entity("MgpTechTickets.Models.ChamadoLog", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.HasOne("MgpTechTickets.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("MgpTechTickets.Models.Chamado", "ChamadoFilho")
                        .WithMany()
                        .HasForeignKey("ChamadoFilhoId");

                    b.HasOne("MgpTechTickets.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Ambiente");

                    b.Navigation("Categoria");

                    b.Navigation("ChamadoFilho");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Cliente", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Filial", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.FilialDados", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FilialId");

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("MgpTechTickets.Models.FilialEndereco", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("FilialId");

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Pendencia", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.HasOne("MgpTechTickets.Models.CanaisComunicacao", "Canal")
                        .WithMany()
                        .HasForeignKey("CanalId");

                    b.HasOne("MgpTechTickets.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.HasOne("MgpTechTickets.Models.Chamado", "Chamado")
                        .WithMany("Pendencias")
                        .HasForeignKey("ChamadoId");

                    b.HasOne("MgpTechTickets.Models.SubCategorias", "SubCategoria")
                        .WithMany()
                        .HasForeignKey("SubCategoriaId");

                    b.HasOne("MgpTechTickets.Models.Users", "UserFinish")
                        .WithMany()
                        .HasForeignKey("UserFinishId");

                    b.HasOne("MgpTechTickets.Models.Users", "User")
                        .WithMany("Pendencias")
                        .HasForeignKey("UserId");

                    b.Navigation("Ambiente");

                    b.Navigation("Canal");

                    b.Navigation("Categoria");

                    b.Navigation("Chamado");

                    b.Navigation("SubCategoria");

                    b.Navigation("User");

                    b.Navigation("UserFinish");
                });

            modelBuilder.Entity("MgpTechTickets.Models.PendenciaImage", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.HasOne("MgpTechTickets.Models.Pendencia", "ChamadoFilho")
                        .WithMany()
                        .HasForeignKey("ChamadoFilhoId");

                    b.Navigation("Ambiente");

                    b.Navigation("ChamadoFilho");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Procedimentos", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Roles", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Setores", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.Navigation("Ambiente");
                });

            modelBuilder.Entity("MgpTechTickets.Models.SubCategorias", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Ambiente", "Ambiente")
                        .WithMany()
                        .HasForeignKey("AmbienteId");

                    b.HasOne("MgpTechTickets.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Ambiente");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Users", b =>
                {
                    b.HasOne("MgpTechTickets.Models.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Chamado", b =>
                {
                    b.Navigation("Pendencias");
                });

            modelBuilder.Entity("MgpTechTickets.Models.Users", b =>
                {
                    b.Navigation("Chamados");

                    b.Navigation("Pendencias");
                });
#pragma warning restore 612, 618
        }
    }
}
