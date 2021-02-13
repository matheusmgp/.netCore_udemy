using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MgpTechTickets.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomeFantasia = table.Column<string>(nullable: false),
                    RazaoSocial = table.Column<string>(nullable: false),
                    Cnpj = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendas_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Canais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Status_ = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Canais_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Status_ = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categorias_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CliNome = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilCnpj = table.Column<string>(nullable: false),
                    FilRazsoc = table.Column<string>(nullable: false),
                    FilStatus = table.Column<string>(nullable: false),
                    FilNomefant = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filiais_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Status_ = table.Column<string>(nullable: false),
                    Tempo = table.Column<string>(nullable: false),
                    TempoRapido = table.Column<string>(nullable: false),
                    TempoMedio = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setores_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Status_ = table.Column<string>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategorias_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilialDados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilialId = table.Column<int>(nullable: false),
                    NomeRepre = table.Column<string>(nullable: true),
                    NomeFinan = table.Column<string>(nullable: true),
                    CpfRepre = table.Column<string>(nullable: true),
                    EmailFinan = table.Column<string>(nullable: true),
                    IdentiRepre = table.Column<string>(nullable: true),
                    TeleFinan = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilialDados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilialDados_Filiais_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filiais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilialEnderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilialId = table.Column<int>(nullable: false),
                    Logradouro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilialEnderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilialEnderecos_Filiais_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filiais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chamados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    FilialId = table.Column<int>(nullable: false),
                    SetorId = table.Column<int>(nullable: false),
                    Status_ = table.Column<string>(nullable: false),
                    Protocolo = table.Column<string>(nullable: false),
                    UserFinishId = table.Column<int>(nullable: true),
                    UserRedirectId = table.Column<int>(nullable: true),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    DataFechamento = table.Column<DateTime>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamados_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamados_Filiais_FilialId",
                        column: x => x.FilialId,
                        principalTable: "Filiais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamados_Setores_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamados_Users_UserFinishId",
                        column: x => x.UserFinishId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamados_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamados_Users_UserRedirectId",
                        column: x => x.UserRedirectId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChamadoLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ChamadoFilhoId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Solucao = table.Column<string>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: false),
                    Status_ = table.Column<string>(nullable: false),
                    DataAlterado = table.Column<DateTime>(nullable: false),
                    Tipo = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChamadoLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChamadoLogs_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChamadoLogs_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChamadoLogs_Chamados_ChamadoFilhoId",
                        column: x => x.ChamadoFilhoId,
                        principalTable: "Chamados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChamadoLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pendencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    UserFinishId = table.Column<int>(nullable: true),
                    ChamadoId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Solucao = table.Column<string>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: false),
                    SubCategoriaId = table.Column<int>(nullable: false),
                    CanalId = table.Column<int>(nullable: false),
                    Imagem = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    DataAbertura = table.Column<DateTime>(nullable: false),
                    DataFechamento = table.Column<DateTime>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false),
                    PendenciaImagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pendencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pendencias_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pendencias_Canais_CanalId",
                        column: x => x.CanalId,
                        principalTable: "Canais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pendencias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pendencias_Chamados_ChamadoId",
                        column: x => x.ChamadoId,
                        principalTable: "Chamados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pendencias_SubCategorias_SubCategoriaId",
                        column: x => x.SubCategoriaId,
                        principalTable: "SubCategorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pendencias_Users_UserFinishId",
                        column: x => x.UserFinishId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pendencias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PendenciaImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChamadoFilhoId = table.Column<int>(nullable: false),
                    PathName = table.Column<string>(nullable: false),
                    AmbienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendenciaImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PendenciaImages_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PendenciaImages_Pendencias_ChamadoFilhoId",
                        column: x => x.ChamadoFilhoId,
                        principalTable: "Pendencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_AmbienteId",
                table: "Agendas",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Canais_AmbienteId",
                table: "Canais",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_AmbienteId",
                table: "Categorias",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ChamadoLogs_AmbienteId",
                table: "ChamadoLogs",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ChamadoLogs_CategoriaId",
                table: "ChamadoLogs",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ChamadoLogs_ChamadoFilhoId",
                table: "ChamadoLogs",
                column: "ChamadoFilhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ChamadoLogs_UserId",
                table: "ChamadoLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_AmbienteId",
                table: "Chamados",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_FilialId",
                table: "Chamados",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_SetorId",
                table: "Chamados",
                column: "SetorId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_UserFinishId",
                table: "Chamados",
                column: "UserFinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_UserId",
                table: "Chamados",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_UserRedirectId",
                table: "Chamados",
                column: "UserRedirectId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_AmbienteId",
                table: "Clientes",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Filiais_AmbienteId",
                table: "Filiais",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_FilialDados_FilialId",
                table: "FilialDados",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_FilialEnderecos_FilialId",
                table: "FilialEnderecos",
                column: "FilialId");

            migrationBuilder.CreateIndex(
                name: "IX_PendenciaImages_AmbienteId",
                table: "PendenciaImages",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PendenciaImages_ChamadoFilhoId",
                table: "PendenciaImages",
                column: "ChamadoFilhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencias_AmbienteId",
                table: "Pendencias",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencias_CanalId",
                table: "Pendencias",
                column: "CanalId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencias_CategoriaId",
                table: "Pendencias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencias_ChamadoId",
                table: "Pendencias",
                column: "ChamadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencias_SubCategoriaId",
                table: "Pendencias",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencias_UserFinishId",
                table: "Pendencias",
                column: "UserFinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Pendencias_UserId",
                table: "Pendencias",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_AmbienteId",
                table: "Roles",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Setores_AmbienteId",
                table: "Setores",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_AmbienteId",
                table: "SubCategorias",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "ChamadoLogs");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "FilialDados");

            migrationBuilder.DropTable(
                name: "FilialEnderecos");

            migrationBuilder.DropTable(
                name: "PendenciaImages");

            migrationBuilder.DropTable(
                name: "Pendencias");

            migrationBuilder.DropTable(
                name: "Canais");

            migrationBuilder.DropTable(
                name: "Chamados");

            migrationBuilder.DropTable(
                name: "SubCategorias");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "Setores");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Ambientes");
        }
    }
}
