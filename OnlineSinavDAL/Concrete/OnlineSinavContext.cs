using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using OnlineSinavModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavDAL.Concrete
{
    public class OnlineSinavContext : DbContext
    {
        //public static readonly ILoggerFactory loggerFactory = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLoggerFactory(loggerFactory)
            //    .EnableSensitiveDataLogging().
            optionsBuilder.UseSqlServer("Server=DESKTOP-69OSIAF; Database=OSS; Trusted_Connection=true;");
        }
        public OnlineSinavContext():base()
        {

        }
        #region Veritabani Tablolar
        public DbSet<Brans> Brans { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<KullaniciRol> KullaniciRols { get; set; }
        public DbSet<Soru> Soru { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Sinav> Sinav { get; set; }
        public DbSet<SinavSoru> SinavSoru { get; set; }
        public DbSet<KullaniciCevap> KullaniciCevap { get; set; }
        public DbSet<KullaniciSinav> KullaniciSinav { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<KullaniciDetay> KullaniciDetays { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<KullaniciKurs> KullaniciKurs { get; set; }
        public DbSet<KursMerkezi> KursMerkezi { get; set; }
        public DbSet<KursDers> KursDers { get; set; }
        public DbSet<Sikayet> Sikayet { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<KullaniciRol>().HasKey(x => new { x.KullaniciId, x.RolId });
            //modelBuilder.Entity<KullaniciRol>().HasOne<Kullanici>(a => a.Kullanici).WithMany(b => b.Rols).HasForeignKey(c => c.KullaniciId);
            //modelBuilder.Entity<KullaniciRol>().HasOne<Rol>(a => a.Rol).WithMany(b => b.Kullanici).HasForeignKey(c => c.RolId);

            //modelBuilder.Entity<Soru>()
            //.HasOne<StudentAddress>(s => s.Address)
            //.WithOne(ad => ad.Student)
            //.HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);
            #region KursDers iliskisi coka cok iliski

            modelBuilder.Entity<KursDers>().HasKey(kd => new { kd.KullaniciId, kd.DersId });

            modelBuilder.Entity<KursDers>()
                .HasOne(sc => sc.Kullanici)
                .WithMany(s => s.KursDers)
                .HasForeignKey(sc => sc.KullaniciId);


            modelBuilder.Entity<KursDers>()
                .HasOne(sc => sc.Ders)
                .WithMany(s => s.KursDers)
                .HasForeignKey(sc => sc.DersId);
            #endregion

            #region KullaniciRoller
            //ara tablonun iki tane keyi olduğunu söylüyor. (ikisi de aslında başka tabloların keyi )
            modelBuilder.Entity<KullaniciRol>().HasKey(kr => new { kr.KullaniciId, kr.RolId });
            //ara tablonun kullanıcı tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<KullaniciRol>()
                .HasOne(kr => kr.Kullanici)
                .WithMany(k => k.KullaniciRoller)
                .HasForeignKey(kr => kr.KullaniciId);
            //ara tablonun rol tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<KullaniciRol>()
                .HasOne(kr => kr.Rol)
                .WithMany(r => r.KullaniciRoller)
                .HasForeignKey(kr => kr.RolId);
            #endregion

            #region SinavSoru
            //ara tablonun iki tane keyi olduğunu söylüyor. (ikisi de aslında başka tabloların keyi )
            modelBuilder.Entity<SinavSoru>().HasKey(kr => new { kr.SinavID, kr.SoruID });
            //ara tablonun kullanıcı tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<SinavSoru>()
                .HasOne(kr => kr.Soru)
                .WithMany(k => k.SinavSoru)
                .HasForeignKey(kr => kr.SoruID);
            //ara tablonun rol tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<SinavSoru>()
                .HasOne(kr => kr.Sinav)
                .WithMany(r => r.SinavSoru)
                .HasForeignKey(kr => kr.SinavID);
            #endregion

            #region KullaniciCevap
            ////ara tablonun iki tane keyi olduğunu söylüyor. (ikisi de aslında başka tabloların keyi )
            //modelBuilder.Entity<KullaniciCevap>().HasKey(kc => new { kc.KullaniciSinavID, kc.SoruID });
            ////ara tablonun kullanıcı tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            //modelBuilder.Entity<KullaniciCevap>()
            //    .HasOne<Soru>(kc => kc.Soru)
            //    //.WithMany(k => k.KullaniciCevap).HasPrincipalKey(x => x.ID)
            //    .HasForeignKey(kc => kc.SoruID);
            ////ara tablonun rol tablosuyla arasındaki bire çok ilişkiyi söylüyor.
           

            #endregion

            #region KullaniciSinav
            //ara tablonun iki tane keyi olduğunu söylüyor. (ikisi de aslında başka tabloların keyi )
            modelBuilder.Entity<KullaniciSinav>().HasKey(kr => new { kr.KullaniciId, kr.SinavId });
            //ara tablonun kullanıcı tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<KullaniciSinav>()
                .HasOne(kr => kr.Kullanici)
                .WithMany(k => k.KullaniciSinav)
                .HasForeignKey(kr => kr.KullaniciId);
            //ara tablonun rol tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<KullaniciSinav>()
                .HasOne(kr => kr.Sinav)
                .WithMany(r => r.KullaniciSinav)
                .HasForeignKey(kr => kr.SinavId);
            #endregion

            #region KullaniciKurs
            //ara tablonun iki tane keyi olduğunu söylüyor. (ikisi de aslında başka tabloların keyi )
            modelBuilder.Entity<KullaniciKurs>().HasKey(kr => new { kr.KullaniciId, kr.KursId });
            //ara tablonun kullanıcı tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<KullaniciKurs>()
                .HasOne(kr => kr.Kullanici)
                .WithMany(k => k.KullaniciKurs)
                .HasForeignKey(kr => kr.KullaniciId);
            //ara tablonun rol tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<KullaniciKurs>()
                .HasOne(kr => kr.Kurs)
                .WithMany(r => r.KullaniciKurs)
                .HasForeignKey(kr => kr.KursId);
            #endregion

            #region Yorum
            modelBuilder.Entity<Yorum>().HasKey(y => new { y.KullaniciId, y.DersId });
            modelBuilder.Entity<Yorum>()
                .HasOne(y => y.Kullanici)
                .WithMany(y => y.Yorumlar)
                .HasForeignKey(y => y.KullaniciId);

            modelBuilder.Entity<Yorum>()
            .HasOne(y => y.Ders)
            .WithMany(y => y.Yorumlar)
            .HasForeignKey(y => y.DersId);

            #endregion

            #region KullaniciDetay
            modelBuilder.Entity<Kullanici>()
                .HasOne<KullaniciDetay>(s => s.KullaniciDetaylari)
                .WithOne(kd => kd.Kullanici)
                .HasForeignKey<KullaniciDetay>(kd => kd.KullaniciID);

            #endregion

            #region Ders
            modelBuilder.Entity<Ders>()
                .HasOne<Kurs>(s => s.Kurs)
                .WithOne(sa => sa.Ders)
                .HasForeignKey<Kurs>(sa => sa.ID);

            #endregion

            #region Kurs
            modelBuilder.Entity<Kurs>()
                 .HasOne<Sinav>(s => s.Sinav)
                 .WithOne(sa => sa.Kurs)
                 .HasForeignKey<Kurs>(s => s.SinavId);

            #endregion

            #region Sikayetler
            //ara tablonun iki tane keyi olduğunu söylüyor. (ikisi de aslında başka tabloların keyi )
            modelBuilder.Entity<Sikayet>().HasKey(s => new { s.DersId, s.KullaniciId });
            //ara tablonun kullanıcı tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<Sikayet>()
                .HasOne(s => s.Kullanici)
                .WithMany(k => k.Sikayetler)
                .HasForeignKey(kr => kr.KullaniciId);
            //ara tablonun rol tablosuyla arasındaki bire çok ilişkiyi söylüyor.
            modelBuilder.Entity<Sikayet>()
                .HasOne(kr => kr.Ders)
                .WithMany(r => r.Sikayetler)
                .HasForeignKey(kr => kr.DersId);
            #endregion

            #region Sinav

            //Kaynak:https://stackoverflow.com/questions/54282804/sql-error-introducing-foreign-key-constraint-may-cause-cycles-or-multiple-casca
      //      modelBuilder.Entity<Sinav>()
      //.HasKey(e => new { e.OgretmenId, e.KaydedenKullaniciId });

            modelBuilder.Entity<Sinav>()
            .HasOne<Kullanici>(e => e.Ogretmen)
            .WithMany(e => e.SinavOgretmen)
            .HasForeignKey(e => e.OgretmenId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sinav>()
                .HasOne<Kullanici>(e => e.KaydedenKullanici)
        .WithMany(e => e.SinavKaydedenKullanici)
                .HasForeignKey(e => e.KaydedenKullaniciId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }
    }
}
