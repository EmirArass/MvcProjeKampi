using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Content -> Heading (Many-to-One)
            modelBuilder.Entity<Content>()
                .HasRequired(c => c.Heading)
                .WithMany(h => h.IContents)
                .HasForeignKey(c => c.HeadingID)
                .WillCascadeOnDelete(false);

            // Content -> Writer (Many-to-One)
            modelBuilder.Entity<Content>()
                .HasRequired(c => c.Writer)
                .WithMany(w => w.IContent)
                .HasForeignKey(c => c.WriterID)
                .WillCascadeOnDelete(false);

            // Writer -> Heading (One-to-Many)
            modelBuilder.Entity<Writer>()
                .HasMany(w => w.IHeadings)
                .WithRequired(h => h.Writer)
                .HasForeignKey(h => h.WriterID)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }*/ 
    }
}
