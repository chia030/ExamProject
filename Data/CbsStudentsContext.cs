using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cbsStudents.Models.Entities;
using cbsStudents.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CbsStudents.Data
{
    public class CbsStudentsContext : IdentityDbContext<StudentPortalUser, IdentityRole, string>
    {
        public CbsStudentsContext(DbContextOptions<CbsStudentsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.UsersSeed(builder);
            this.SeedPosts(builder);
            this.SeedComments(builder);
            this.SeedStudents(builder);
            this.SeedEvents(builder);
        }

        

        public DbSet<Post> Posts { get; set; }
        public DbSet<cbsStudents.Models.Entities.Comment> Comment { get; set; }
        public DbSet<cbsStudents.Models.Entities.Student> Student { get; set; }

        public DbSet<cbsStudents.Models.Entities.Event> Event { get; set; }


        private void UsersSeed(ModelBuilder builder)
        {
            var user1 = new StudentPortalUser
            {
                Id = "1",
                FirstName = "TestName",
                LastName = "TestName",
                Email = "chrk@kea.dk",
                EmailConfirmed = true,
                UserName = "chrk@kea.dk",
            };

            var user2 = new StudentPortalUser
            {
                Id = "2",
                FirstName = "TestName",
                LastName = "TestName",
                Email = "test@kea.dk",
                EmailConfirmed = true,
                UserName = "test@kea.dk",
            };

            PasswordHasher<StudentPortalUser> passHash = new PasswordHasher<StudentPortalUser>();
            user1.PasswordHash = passHash.HashPassword(user1, "aA123456!");
            user2.PasswordHash = passHash.HashPassword(user2, "aA123456!");

            builder.Entity<StudentPortalUser>().HasData(
                user1, user2
            );
        }
        private void SeedPosts(ModelBuilder builder)
        {
            builder.Entity<Post>().HasData(
                new Post() { Id = 1, Created = DateTime.Now, Text = "This is post 1", Title = "Post no 1", Status = PostStatus.DRAFT },
                new Post() { Id = 2, Created = DateTime.Now, Text = "This is post 2", Title = "Post no 2", Status = PostStatus.DRAFT },
                new Post() { Id = 3, Created = DateTime.Now, Text = "This is post 3", Title = "Post no 3", Status = PostStatus.DRAFT }
            );
        }

        private void SeedComments(ModelBuilder builder)
        {
            builder.Entity<Comment>().HasData(
                new Comment() { CommentId = 1, Text = "Hello", TimeStamp = DateTime.Now, PostId = 1, UserId = "1" },
                new Comment() { CommentId = 2, Text = "Hello again", TimeStamp = DateTime.Now, PostId = 1, UserId = "2" },
                new Comment() { CommentId = 3, Text = "Hi", TimeStamp = DateTime.Now, PostId = 2, UserId = "1" },
                new Comment() { CommentId = 4, Text = "Bye", TimeStamp = DateTime.Now, PostId = 3, UserId = "1" }
            );
        }

        private void SeedStudents(ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(
                new Student() { StudentId = 1, FirstName = "Bruce", LastName = "Wayne", StudyProgramme = "BSc in Martial Arts" },
                new Student() { StudentId = 2, FirstName = "Selina", LastName = "Kyle", StudyProgramme = "BSc in Martial Arts" },
                new Student() { StudentId = 3, FirstName = "James", LastName = "Gordon", StudyProgramme = "MSc in Criminal Justice" },
                new Student() { StudentId = 4, FirstName = "Carmine", LastName = "Falcone", StudyProgramme = "MSc in Mischievous Arts" }
            );
        }

        private void SeedEvents(ModelBuilder builder)
        {
            builder.Entity<Event>().HasData(
                new Event() { EventId = 1, Title = "Introduction Week", Description = "?", DateTime = DateTime.Now, Location = "KEA Main Campus", UserId = "1" },
                new Event() { EventId = 2, Title = "Test Event", Description = "This is just a test", DateTime = DateTime.Now, Location = "KEA Main Campus", UserId = "1" }
            );
        }

    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<StudentPortalUser>
        {
            public void Configure(EntityTypeBuilder<StudentPortalUser> builder)
            {
                builder.Property(u => u.FirstName).HasMaxLength(255);
                builder.Property(u => u.LastName).HasMaxLength(255);
            }
        }
        
}