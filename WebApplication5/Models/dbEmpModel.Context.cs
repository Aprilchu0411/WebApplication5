﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Common;//新增
    using System.Data.Entity.Core.EntityClient;//新增
    using System.Configuration;//新增
    public partial class dbEmpEntities : DbContext
    {
        public dbEmpEntities()
            : base("name=dbEmpEntities")
        {
            var originalConnectionString = ConfigurationManager.ConnectionStrings["dbEmpEntities"].ConnectionString;//修改Entities名稱
            var entityBuilder = new EntityConnectionStringBuilder(originalConnectionString);
            var factory = DbProviderFactories.GetFactory(entityBuilder.Provider);
            var providerBuilder = factory.CreateConnectionStringBuilder();

            providerBuilder.ConnectionString = entityBuilder.ProviderConnectionString;

            providerBuilder.Add("Password", "yzuim1112netdbA"); // 加入SQL密碼資料

            entityBuilder.ProviderConnectionString = providerBuilder.ToString();

            this.Database.Connection.ConnectionString = entityBuilder.ProviderConnectionString;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tablemy1Tables1101661> Tablemy1Tables1101661 { get; set; }
        public virtual DbSet<Tablemy2Tables1101661> Tablemy2Tables1101661 { get; set; }
        public virtual DbSet<Tablemy3Tables1101661> Tablemy3Tables1101661 { get; set; }
        public virtual DbSet<Tablemy4Tables1101661> Tablemy4Tables1101661 { get; set; }

        public System.Data.Entity.DbSet<WebApplication5.Models.Tablemy5Tables1101661> Tablemy5Tables1101661 { get; set; }
    }
}
