﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mioto.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_MiotoEntities : DbContext
    {
        public DB_MiotoEntities()
            : base("name=DB_MiotoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CCCD> CCCD { get; set; }
        public virtual DbSet<ChinhSachChietKhau> ChinhSachChietKhau { get; set; }
        public virtual DbSet<ChuXe> ChuXe { get; set; }
        public virtual DbSet<DanhGia> DanhGia { get; set; }
        public virtual DbSet<DoanhThuCongTy> DoanhThuCongTy { get; set; }
        public virtual DbSet<DoanhThuChuXe> DoanhThuChuXe { get; set; }
        public virtual DbSet<DonThueXe> DonThueXe { get; set; }
        public virtual DbSet<GPLX> GPLX { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MaGiamGia> MaGiamGia { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhiHuyChuyen> PhiHuyChuyen { get; set; }
        public virtual DbSet<ThanhToan> ThanhToan { get; set; }
        public virtual DbSet<Xe> Xe { get; set; }
    }
}
