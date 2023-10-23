using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTLnhom07.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BTLnhom07.Models.HoaDon> HoaDon { get; set; } = default!;

        public DbSet<BTLnhom07.Models.KhachHang> KhachHang { get; set; } = default!;

        public DbSet<BTLnhom07.Models.NhanVien> NhanVien { get; set; } = default!;

        public DbSet<BTLnhom07.Models.SanPham> SanPham { get; set; } = default!;

        public DbSet<BTLnhom07.Models.Kho> Kho { get; set; } = default!;
    }
