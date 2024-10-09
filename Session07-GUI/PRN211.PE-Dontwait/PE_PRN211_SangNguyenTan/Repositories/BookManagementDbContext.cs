using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories.Entities;

namespace Repositories;

public partial class BookManagementDbContext : DbContext
{
    public BookManagementDbContext()
    {
    }

    public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }
    
    //hàm đọc file cơ sở dữ liệu appsettings
    //private vì chỉ cần dùng nội bộ
    private string? GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
        var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];
        //sửa lại cái tag cho phù hợp

        return strConn;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(GetConnectionString()); 
                                        //REMOVE HASHCODE CONNNECT - STRING
                                        //THAY BẰNG LỜI GỌI HÀM JSON Ở TRÊN
                                        //CHỐT LẠI
                                        //1. TẠO 3 PROJECT GUI, SERVICE, REPO, TẠO THAM CHIẾU - COPY TO LOCAL
                                        //2. KIỂM TRA CSDL - CHẠY FILE SCRIPT TRƯỜNG CHO
                                        //3. TẠO TOOL Ở DÒNG LỆNH EF
                                        //4. SUY NGƯỢC TỪ DB TỪ CÂU LỆNH SCAFFOLD - BẮT BUỘC ADD 4 THƯ VIỆN - NHỚ CHẠY BUILD
                                        //              SAU ĐÓ CHẠY LỆNH SCAFFOLD TRONG FILE TXT
                                        // > dotnet ef dbcontext scaffold "Server=(local);Database= BookManagementDb;UID=sa;PWD=sa123456;TrustServerCertificate=True" "Microsoft.EntityFrameworkCore.SqlServer" --output-dir "Entities" --context-dir ".\"
                                        //lệnh này giúp sinh thư mục, từ db to class - DB first       
                                        //5. TẠO JSON CẤU HÌNH
                                        //6. COPY TO OUPUT
                                        //7. SỬA HASHCODE ĐỌC DỮ LIỆU



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C207C2FE2357");

            entity.ToTable("Book");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.BookName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");

            entity.HasOne(d => d.BookCategory).WithMany(p => p.Books)
                .HasForeignKey(d => d.BookCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book_BookCategory");
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.HasKey(e => e.BookCategoryId).HasName("PK__BookCate__6347EC0488F16882");

            entity.ToTable("BookCategory");

            entity.Property(e => e.BookCategoryId).ValueGeneratedNever();
            entity.Property(e => e.BookGenreType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__UserAcco__0CF04B184BBBFE2D");

            entity.ToTable("UserAccount");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
