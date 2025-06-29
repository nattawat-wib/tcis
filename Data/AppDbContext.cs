using Microsoft.EntityFrameworkCore;
using tcirs_service.Models;
using tcirs_service.Models.Master;
using tcirs_service.Models.Umgs;

namespace tcirs_service.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; } = null;
        public DbSet<ImportControl> ImportControls { get; set; } = null!;
        public DbSet<ImportDetail> ImportDetail { get; set; } = null!;
        public DbSet<ImportListA> ImportListAs { get; set; }
        public DbSet<ImportListF> ImportListFs { get; set; }
        public DbSet<ImportListFDetail> ImportListFDetails { get; set; }
        public DbSet<ImportVassel> ImportVassels { get; set; }
        public DbSet<InspectionListF> InspectionListFs { get; set; }
        public DbSet<LoginLog> LoginLogs { get; set; }
        public DbSet<Models.Master.MsCity> MasterMsCities { get; set; }
        public DbSet<Models.Umgs.MsCity> UmgsMsCities { get; set; }
        public DbSet<MsDocument> MsDocuments { get; set; }
        public DbSet<MsRole> MsRoles { get; set; }
        public DbSet<MsTraffic> MsTraffics { get; set; }
        public DbSet<MsUserRole> MsUserRoles { get; set; }
        public DbSet<MsUsers> MsUsers { get; set; }
        public DbSet<OverdueResult> OverdueResults { get; set; }
        public DbSet<SendDocAttachment> SendDocAttachments { get; set; }
        public DbSet<SendDocDetail> SendDocDetails { get; set; }
        public DbSet<SendDocHeader> SendDocHeaders { get; set; }
        public DbSet<SendDocPdf> SendDocPdfs { get; set; }
        public DbSet<SendDocStatus> SendDocStatuses { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set default schema if needed
            modelBuilder.HasDefaultSchema("ugms");

            // Optional: Add Fluent API configurations here if you need more control

            // Composite keys
            modelBuilder.Entity<MsUserRole>().HasKey(x => new { x.UserId, x.RoleId });

            modelBuilder.Entity<OverdueResult>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("overdue_result", "ugms");
            });


            modelBuilder.Entity<ImportListFDetail>().ToTable("import_list_f_detail", "ugms");
            modelBuilder.Entity<ImportVassel>().ToTable("import_vassel", "ugms");
            modelBuilder.Entity<InspectionListF>().ToTable("inspection_listf", "ugms");
            modelBuilder.Entity<LoginLog>().ToTable("loginlog", "ugms");
            modelBuilder.Entity<Models.Umgs.MsCity>().ToTable("mscity", "ugms");
            modelBuilder.Entity<Models.Master.MsCity>().ToTable("mscity", "master");
            modelBuilder.Entity<MsDocument>().ToTable("msdocument", "ugms");
            modelBuilder.Entity<MsRole>().ToTable("msrole", "ugms");
            modelBuilder.Entity<MsTraffic>().ToTable("mstraffic", "ugms");
            modelBuilder.Entity<MsUserRole>().ToTable("msuserrole", "ugms");
            modelBuilder.Entity<MsUsers>().ToTable("msusers", "ugms");
            modelBuilder.Entity<SendDocAttachment>().ToTable("send_doc_attachments", "ugms");
            modelBuilder.Entity<SendDocDetail>().ToTable("send_doc_detail", "ugms");
            modelBuilder.Entity<SendDocHeader>().ToTable("send_doc_header", "ugms");
            modelBuilder.Entity<SendDocPdf>().ToTable("send_doc_pdf", "ugms");
            modelBuilder.Entity<SendDocStatus>().ToTable("send_doc_status", "ugms");

        }
    }
}
