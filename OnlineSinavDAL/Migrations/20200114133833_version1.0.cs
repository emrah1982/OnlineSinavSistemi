using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineSinavDAL.Migrations
{
    public partial class version10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brans",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UstBransId = table.Column<int>(nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    LogoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brans", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Brans_Brans_UstBransId",
                        column: x => x.UstBransId,
                        principalTable: "Brans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    KursId = table.Column<int>(nullable: false),
                    Baslik = table.Column<string>(nullable: true),
                    Icerik = table.Column<string>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true),
                    DokumanUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ad = table.Column<string>(maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(maxLength: 50, nullable: true),
                    TcNo = table.Column<string>(maxLength: 11, nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IsEmailActive = table.Column<bool>(nullable: false),
                    FotoUrl = table.Column<string>(nullable: true),
                    KayitTarihi = table.Column<DateTime>(nullable: false),
                    Sifre = table.Column<string>(maxLength: 15, nullable: false),
                    ActivationCode = table.Column<Guid>(nullable: false),
                    ResetPasswordCode = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KursMerkezi",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ad = table.Column<string>(nullable: true),
                    Adres = table.Column<string>(nullable: true),
                    TelefonNumarasi = table.Column<string>(nullable: true),
                    Ilce = table.Column<int>(nullable: false),
                    Il = table.Column<int>(nullable: false),
                    LocationUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KursMerkezi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Ad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionMessage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    KullaniciId = table.Column<int>(nullable: false),
                    HataMesaji = table.Column<string>(nullable: true),
                    HataUrl = table.Column<string>(nullable: true),
                    HataMethodu = table.Column<string>(nullable: true),
                    HataSatiri = table.Column<string>(nullable: true),
                    HataYeri = table.Column<string>(nullable: true),
                    HataZamani = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionMessage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExceptionMessage_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciDetays",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    KullaniciID = table.Column<int>(nullable: false),
                    Mezuniyet = table.Column<int>(nullable: false),
                    Adres = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciDetays", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KullaniciDetays_Kullanici_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sikayet",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false),
                    DersId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sikayet", x => new { x.DersId, x.KullaniciId });
                    table.ForeignKey(
                        name: "FK_Sikayet_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sikayet_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Soru",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SoruMetni = table.Column<string>(nullable: true),
                    Cevap = table.Column<string>(nullable: true),
                    ZorlukDerecesi = table.Column<byte>(nullable: false),
                    BransID = table.Column<int>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    KullaniciID = table.Column<int>(nullable: false),
                    OnaylandiMi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soru", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Soru_Brans_BransID",
                        column: x => x.BransID,
                        principalTable: "Brans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Soru_Kullanici_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    DersId = table.Column<int>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => new { x.KullaniciId, x.DersId });
                    table.ForeignKey(
                        name: "FK_Yorum_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorum_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sinav",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    KursMerkeziId = table.Column<int>(nullable: false),
                    SinavTarihi = table.Column<DateTime>(nullable: false),
                    SinavSaati = table.Column<int>(nullable: false),
                    Suresi = table.Column<int>(nullable: false),
                    SoruSayisi = table.Column<byte>(nullable: false),
                    Sinif = table.Column<string>(nullable: true),
                    BransId = table.Column<int>(nullable: false),
                    Kontejan = table.Column<byte>(nullable: false),
                    OturumBittiMi = table.Column<bool>(nullable: false),
                    OgretmenId = table.Column<int>(nullable: false),
                    KaydedenKullaniciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinav", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sinav_Brans_BransId",
                        column: x => x.BransId,
                        principalTable: "Brans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sinav_Kullanici_KaydedenKullaniciId",
                        column: x => x.KaydedenKullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sinav_KursMerkezi_KursMerkeziId",
                        column: x => x.KursMerkeziId,
                        principalTable: "KursMerkezi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sinav_Kullanici_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciRols",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false),
                    RolId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciRols", x => new { x.KullaniciId, x.RolId });
                    table.ForeignKey(
                        name: "FK_KullaniciRols_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciRols_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciCevap",
                columns: table => new
                {
                    KullaniciSinavID = table.Column<int>(nullable: false),
                    SoruID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciCevap", x => new { x.KullaniciSinavID, x.SoruID });
                    table.ForeignKey(
                        name: "FK_KullaniciCevap_Sinav_KullaniciSinavID",
                        column: x => x.KullaniciSinavID,
                        principalTable: "Sinav",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciCevap_Soru_SoruID",
                        column: x => x.SoruID,
                        principalTable: "Soru",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciSinav",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false),
                    SinavId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    SinavBittiMi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciSinav", x => new { x.KullaniciId, x.SinavId });
                    table.ForeignKey(
                        name: "FK_KullaniciSinav_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciSinav_Sinav_SinavId",
                        column: x => x.SinavId,
                        principalTable: "Sinav",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kurs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    BaslamaTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    BitttiMi = table.Column<bool>(nullable: false),
                    SinavId = table.Column<int>(nullable: false),
                    HaftalikCalisma = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kurs_Ders_ID",
                        column: x => x.ID,
                        principalTable: "Ders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kurs_Sinav_SinavId",
                        column: x => x.SinavId,
                        principalTable: "Sinav",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinavSoru",
                columns: table => new
                {
                    SinavID = table.Column<int>(nullable: false),
                    SoruID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinavSoru", x => new { x.SinavID, x.SoruID });
                    table.ForeignKey(
                        name: "FK_SinavSoru_Sinav_SinavID",
                        column: x => x.SinavID,
                        principalTable: "Sinav",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinavSoru_Soru_SoruID",
                        column: x => x.SoruID,
                        principalTable: "Soru",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciKurs",
                columns: table => new
                {
                    KursId = table.Column<int>(nullable: false),
                    KullaniciId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Durum = table.Column<bool>(nullable: false),
                    KullaniciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciKurs", x => new { x.KullaniciId, x.KursId });
                    table.ForeignKey(
                        name: "FK_KullaniciKurs_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciKurs_Kurs_KursId",
                        column: x => x.KursId,
                        principalTable: "Kurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KursDers",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(nullable: false),
                    DersId = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    KayitTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KursDers", x => new { x.KullaniciId, x.DersId });
                    table.ForeignKey(
                        name: "FK_KursDers_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KursDers_Kurs_ID",
                        column: x => x.ID,
                        principalTable: "Kurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KursDers_Kullanici_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brans_UstBransId",
                table: "Brans",
                column: "UstBransId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionMessage_KullaniciId",
                table: "ExceptionMessage",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciCevap_SoruID",
                table: "KullaniciCevap",
                column: "SoruID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciDetays_KullaniciID",
                table: "KullaniciDetays",
                column: "KullaniciID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciKurs_KursId",
                table: "KullaniciKurs",
                column: "KursId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciRols_RolId",
                table: "KullaniciRols",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciSinav_SinavId",
                table: "KullaniciSinav",
                column: "SinavId");

            migrationBuilder.CreateIndex(
                name: "IX_Kurs_SinavId",
                table: "Kurs",
                column: "SinavId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KursDers_DersId",
                table: "KursDers",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_KursDers_ID",
                table: "KursDers",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sikayet_KullaniciId",
                table: "Sikayet",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_BransId",
                table: "Sinav",
                column: "BransId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_KaydedenKullaniciId",
                table: "Sinav",
                column: "KaydedenKullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_KursMerkeziId",
                table: "Sinav",
                column: "KursMerkeziId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinav_OgretmenId",
                table: "Sinav",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_SinavSoru_SoruID",
                table: "SinavSoru",
                column: "SoruID");

            migrationBuilder.CreateIndex(
                name: "IX_Soru_BransID",
                table: "Soru",
                column: "BransID");

            migrationBuilder.CreateIndex(
                name: "IX_Soru_KullaniciID",
                table: "Soru",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_DersId",
                table: "Yorum",
                column: "DersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExceptionMessage");

            migrationBuilder.DropTable(
                name: "KullaniciCevap");

            migrationBuilder.DropTable(
                name: "KullaniciDetays");

            migrationBuilder.DropTable(
                name: "KullaniciKurs");

            migrationBuilder.DropTable(
                name: "KullaniciRols");

            migrationBuilder.DropTable(
                name: "KullaniciSinav");

            migrationBuilder.DropTable(
                name: "KursDers");

            migrationBuilder.DropTable(
                name: "Sikayet");

            migrationBuilder.DropTable(
                name: "SinavSoru");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Kurs");

            migrationBuilder.DropTable(
                name: "Soru");

            migrationBuilder.DropTable(
                name: "Ders");

            migrationBuilder.DropTable(
                name: "Sinav");

            migrationBuilder.DropTable(
                name: "Brans");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "KursMerkezi");
        }
    }
}
